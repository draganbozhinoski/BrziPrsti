using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BrziPrsti
{
    public class SaveLoadData
    {
        public void SaveData(List<UserScore> userScores)
        {
            FileStream fs = new FileStream("DataFile.dat", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                bf.Serialize(fs, userScores);
            }
            catch (SerializationException ex)
            {

            }
            finally
            {
                fs.Close();
                Leaderboard board = new Leaderboard();
                board.init();
                board.ShowDialog();
            }
        }

        public List<UserScore> GetData()
        {
            List<UserScore> scores1 = new List<UserScore>();
            FileStream fs = new FileStream("DataFile.dat", FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                // Deserialize the hashtable from the file and
                // assign the reference to the local variable.
                scores1 = (List<UserScore>)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {

            }
            finally
            {
                fs.Close();
                
            }
            return scores1;
        }
    }
}
