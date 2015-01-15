using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Structurer
{
    // Class used to read the file and generate results
    class BinaryParser
    {
        public Dictionary<string, string> Result = new Dictionary<string, string>();
        
        Dictionary<int, StructBlock> blocks = new Dictionary<int, StructBlock>();
        int block = 0;

        // Constructor: set block to 0 and create a new list of blocks
        public BinaryParser()
        {
            block = 0;
            blocks = new Dictionary<int, StructBlock>();
        }

        /// <summary>
        /// Parses a file
        /// If it returns false, you can check Result["___ERROR"] for information.
        /// </summary>
        /// <param name="structure">The structure to be used</param>
        /// <param name="file">the file to be parsed</param>
        /// <returns>true on success, false otherwise</returns>
        public bool Parse(StructData structure, string file)
        {
            try
            {
                // Copy the structure to a array
                StructData.StructElement[] elements = structure._Struct.ToArray();
                using (BinaryReader br = new BinaryReader(File.OpenRead(file)))
                {
                    // Run through each element
                    for (int i = 0; i < elements.Length; i++)
                    {
                        // If the element is a block start, parse this block,
                        // else read the field
                        if (elements[i].type == StructData.ElementType.Block)
                        {
                            block++; // Increase the block count

                            // Create a new block or add a new element to it
                            if (blocks.ContainsKey(block)) blocks[block] = new StructBlock() { name = elements[i].name, repeat = ParseSize(elements[i].metadata), pointer = 0 };
                            else blocks.Add(block, new StructBlock() { name = elements[i].name, repeat = ParseSize(elements[i].metadata) });

                            int block_end = 0;
                            i++;

                            // Search for block end
                            for (int j = i; j < elements.Length; j++)
                            {
                                if (elements[j].type == StructData.ElementType.BlockEnd)
                                {
                                    block_end = j;
                                    break;
                                }
                            }

                            // Repeat the structure a number of times
                            for (int j = 0; j < blocks[block].repeat; j++)
                            {
                                // For each repeat, reads until end of block is reached
                                for (int k = i; k < block_end; k++)
                                {
                                    ParseElement(elements[k], br);
                                }

                                blocks[block].pointer++;
                            }

                            // Moves the pointer
                            i = block_end;
                        }
                        else
                        {
                            ParseElement(elements[i], br);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // In case of error, add the message to the result
                Result.Add("___ERROR", e.Message);
                return false;
            }

            return true;
        }

        // Read an element and add the value to the Result
        private void ParseElement(StructData.StructElement ele, BinaryReader br)
        {
            // Switch through the types
            switch (ele.type)
            {
                case StructData.ElementType.Byte:
                    AddResult(ele.name, br.ReadByte().ToString());
                    break;

                case StructData.ElementType.Int16:
                    AddResult(ele.name, br.ReadInt16().ToString());
                    break;

                case StructData.ElementType.Int32:
                    AddResult(ele.name, br.ReadInt32().ToString());
                    break;

                case StructData.ElementType.Int64:
                    AddResult(ele.name, br.ReadInt64().ToString());
                    break;

                case StructData.ElementType.String:
                    AddResult(ele.name, Encoding.ASCII.GetString(br.ReadBytes(ParseSize(ele.metadata))));
                    break;
            }
        }

        // Adds the result to the Result array
        private void AddResult(string key, string value)
        {
            // Creates a prefix to the field based on block names
            StringBuilder prefix = new StringBuilder("");
            for (int i = 1; i <= block; i++)
            {
                prefix.Append(blocks[i].name + blocks[i].pointer + ".");
            }

            // Add the result
            Result.Add(prefix.ToString() + key, value);
        }

        /// <summary>
        /// Converts size metadata to an integer, applying special commands
        /// </summary>
        /// <param name="data">metadata to be parsed</param>
        /// <returns>the size</returns>
        public int ParseSize(string data)
        {
            int size;

            // If can be parsed to Int32, means that it is a number only
            // else, there is special conditions.
            if (Int32.TryParse(data, out size))
            {
                return size;
            }
            else
            {
                // val: => get the value of a field.
                if (data.StartsWith("val:"))
                {
                    return Int32.Parse(Result[data.Substring(4)]);
                }
            }
            return 0; // If it fails
        }
    }

    // Represents a collection of fields from a file
    class StructData
    {
        public List<StructElement> _Struct = new List<StructElement>();

        // Represents one field
        public class StructElement
        {
            // The type of the field
            public ElementType type { get; set; }
            // The name of the field
            public string name { get; set; }
            // Special informations used by some types, see docs.
            public string metadata { get; set; }
        }

        // Available types
        public enum ElementType
        {
            // 1 Byte
            Byte,
            // 2 Bytes signed integer number
            Int16,
            // 4 Bytes signed integer number
            Int32,
            // 8 Bytes signed integer number
            Int64,
            // A string
            String,

            // Start of a Block
            Block,
            // End of a Block
            BlockEnd
        }

        // Add an element to the collection (type/name only)
        public void Add(ElementType type, string name)
        {
            Add(type, name, "");
        }

        // Add an element to the collection (type, name and metadata)
        public void Add(ElementType type, string name, string metadata)
        {
            if (metadata.Equals(""))
            {
                _Struct.Add(new StructElement() { type = type, name = name });
            }
            else
            {
                _Struct.Add(new StructElement() { type = type, name = name, metadata = metadata });
            }
        }
    }

    // Represents the structure of a Block
    class StructBlock
    {
        public string name { get; set; }
        public int repeat { get; set; }
        public int pointer { get; set; }
    }
}
