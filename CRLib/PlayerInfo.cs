using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.IO;
namespace CRLib
{
    [Serializable]
    public class PlayerInfo
    {
        public string Name { get; }
        public int Side { get; }
        public double Time { get; }
        public PlayerInfo(string name, int side, double time)
        {
            Name = name;
            Side = side;
            Time = time;
        }
        static private BinaryFormatter bin = new BinaryFormatter();
        /// <summary>
        /// Saves an array of PlayerInfo to a bin file
        /// </summary>
        /// <param name="arr">Players' information</param>
        /// <param name="path">File path</param>
        static public void Save(List<PlayerInfo> arr, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
                bin.Serialize(fs, arr);
        }
        /// <summary>
        /// Loads the players' information
        /// </summary>
        /// <param name="path">File path</param>
        /// <returns>An array of PlayerInfo</returns>
        static public List<PlayerInfo> Load(string path)
        {
            if (!File.Exists(path) || File.ReadAllText(path).Length == 0)
                throw new IOException("File doesn't exist");
            using (FileStream fs = new FileStream(path, FileMode.Open))
                return (List<PlayerInfo>)bin.Deserialize(fs);
        }
    }
}
