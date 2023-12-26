using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BayesPapers
{
    public partial class FormMain : Form
    {
        private const string _dataFolder = "Data";

        private const string _dataTrain1Folder = "Data/1/Train";
        private const string _dataTrain2Folder = "Data/2/Train";

        private const string _dataTest1Folder = "Data/1/Test";
        private const string _dataTest2Folder = "Data/2/Test";

        private const string _wordFrequecyFile = "words_frequency.txt";
        private const string _wordEffectiveFile = "words_effective.txt";
        private const string _classAttributesFile = "class_attributes.txt";

        private const int _classAttributesCount = 25;


        List<WordTrainInfo> TrainInfo = new List<WordTrainInfo>();


        public FormMain()
        {
            InitializeComponent();
        }


        private void buttonWordsFrequency_Click(object sender, EventArgs e)
        {
            try
            {
                CalculateWordsFrequency(_dataTrain1Folder);
                CalculateWordsFrequency(_dataTrain2Folder);

                MessageBox.Show("فایل فراوانی کلمات برای داده های آموزشی ساخته شد.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در عملیات: " + ex.Message);
            }
        }

        private void CalculateWordsFrequency(string trainFolder)
        {
            Dictionary<string, int> wordsFreq = new Dictionary<string, int>();

            DirectoryInfo dirInfo = new DirectoryInfo(trainFolder);
            var files = dirInfo.GetFiles().Where(f => !f.Name.EndsWith(".txt"));

            foreach (var currentFile in files)
            {
                string lineText;
                StreamReader sr = new StreamReader(currentFile.FullName);
                while ((lineText = sr.ReadLine()) != null)
                {
                    string[] words = lineText
                                         .Replace("?", " ")
                                         .Replace("/", " ")
                                         .Replace("\\", " ")
                                         .Replace("#", " ")
                                         .Replace("%", " ")
                                         .Replace("(", " ")
                                         .Replace(")", " ")
                                         .Replace("\"", " ")
                                         .Replace("*", " ")
                                         .Replace("=", " ")
                                         .Replace("+", " ")
                                         .Replace("-", " ")
                                         .Replace("^", " ")
                                         .Replace("'", " ")
                                         .Replace("`", " ")
                                         .Replace("<", " ")
                                         .Replace(">", " ")
                                         .Replace("_", " ")
                                         .Replace("$", " ")
                                         .Replace("[", " ")
                                         .Replace("]", " ")
                                         .Replace("{", " ")
                                         .Replace("}", " ")
                                         .Replace("@", " ")
                                         .Replace("|", " ")
                                         .Replace("~", " ")
                                         .Replace("!", " ")
                                         .Replace(".", " ")
                                         .Replace(",", " ")
                                         .Replace(";", " ")
                                         .Replace(":", " ")
                                         .Split(' ');

                    for (int i = 0; i < words.Length; i++)
                    {
                        string currentWord = words[i].Trim().ToLower();
                        if (currentWord.Length > 3)
                        {
                            if (wordsFreq.Keys.Contains(currentWord))
                            {
                                wordsFreq[currentWord]++;
                            }
                            else
                            {
                                wordsFreq.Add(currentWord, 1);
                            }
                        }
                    }
                }
            }

            List<string> wordsFrequncyLines = new List<string>();
            foreach (var key in wordsFreq.Keys.OrderBy(k => k))
            {
                wordsFrequncyLines.Add(wordsFreq[key].ToString() + " = " + key);
            }

            string wordsFrequecyFilePath = Path.Combine(trainFolder, _wordFrequecyFile);
            File.WriteAllLines(wordsFrequecyFilePath, wordsFrequncyLines.ToArray());
        }

        private void buttonEffectiveWords_Click(object sender, EventArgs e)
        {

            try
            {
                List<WordCount> wordsCount1 = GetWordsCount(Path.Combine(_dataTrain1Folder, _wordFrequecyFile));
                List<WordCount> wordsCount2 = GetWordsCount(Path.Combine(_dataTrain2Folder, _wordFrequecyFile));

                List<WordCount> wordsEffective1 = GetWordseffective(wordsCount1, new List<WordCount>[] { wordsCount2 });

                List<string> wordsEffectiveLines = new List<string>();
                foreach (var currentWordEffective in wordsEffective1)
                {
                    wordsEffectiveLines.Add(currentWordEffective.Count.ToString() + " = " + currentWordEffective.Word);
                }

                string wordsEffectiveFilePath = Path.Combine(_dataTrain1Folder, _wordEffectiveFile);
                File.WriteAllLines(wordsEffectiveFilePath, wordsEffectiveLines.ToArray());
                string classAttributeFilePath = Path.Combine(_dataTrain1Folder, _classAttributesFile);
                File.WriteAllLines(classAttributeFilePath, wordsEffective1.OrderByDescending(w => w.Count).Take(_classAttributesCount).Select(w => w.Word).ToArray());



                List<WordCount> wordsEffective2 = GetWordseffective(wordsCount2, new List<WordCount>[] { wordsCount1 });

                wordsEffectiveLines = new List<string>();
                foreach (var currentWordEffective in wordsEffective2)
                {
                    wordsEffectiveLines.Add(currentWordEffective.Count.ToString() + " = " + currentWordEffective.Word);
                }

                wordsEffectiveFilePath = Path.Combine(_dataTrain2Folder, _wordEffectiveFile);
                File.WriteAllLines(wordsEffectiveFilePath, wordsEffectiveLines.ToArray());
                classAttributeFilePath = Path.Combine(_dataTrain2Folder, _classAttributesFile);
                File.WriteAllLines(classAttributeFilePath, wordsEffective2.OrderByDescending(w => w.Count).Take(_classAttributesCount).Select(w => w.Word).ToArray());

                MessageBox.Show("فایل مقدار موثر کلمات برای داده های آموزشی ساخته شد.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در عملیات: " + ex.Message);
            }
        }

        private List<WordCount> GetWordseffective(List<WordCount> classWords, List<WordCount>[] otherClassesWords)
        {
            List<WordCount> wordsEffectiveCount = new List<WordCount>();
            foreach (var currentWordCount in classWords)
            {
                int count = currentWordCount.Count;
                int sumCount = 0;
                foreach (var OtherClassWordInfo in otherClassesWords)
                {
                    WordCount otherWordCount = OtherClassWordInfo.FirstOrDefault(w => w.Word == currentWordCount.Word);
                    if (otherWordCount != null)
                    {
                        sumCount += otherWordCount.Count;
                    }
                }

                wordsEffectiveCount.Add(
                    new WordCount()
                    {
                        Word = currentWordCount.Word,
                        Count = count - sumCount
                    });
            }

            return wordsEffectiveCount;
        }

        private List<WordCount> GetWordsCount(string filePath)
        {
            List<WordCount> wordsCount = new List<WordCount>();

            string[] wordsCountLines = File.ReadAllLines(filePath);
            for (int i = 0; i < wordsCountLines.Length; i++)
            {
                string[] wordInfo = wordsCountLines[i].Split('=');

                wordsCount.Add(
                    new WordCount()
                    {
                        Word = wordInfo[1].Trim(),
                        Count = Convert.ToInt32(wordInfo[0])
                    });
            }

            return wordsCount;
        }

        private void buttonTrain_Click(object sender, EventArgs e)
        {
            try
            {
                HashSet<string> keywords = new HashSet<string>();

                string keywordsPath = Path.Combine(_dataTrain1Folder, _classAttributesFile);
                string[] keywords1 = File.ReadAllLines(keywordsPath);
                for (int i = 0; i < keywords1.Length; i++)
                {
                    keywords.Add(keywords1[i]);
                }

                keywordsPath = Path.Combine(_dataTrain2Folder, _classAttributesFile);
                string[] keywords2 = File.ReadAllLines(keywordsPath);
                for (int i = 0; i < keywords2.Length; i++)
                {
                    keywords.Add(keywords2[i]);
                }


                foreach (var keyword in keywords)
                {
                    Dictionary<int, int> availabilties = new Dictionary<int, int>();
                    int availablity1 = CalculateWordAvailability(keyword, _dataTrain1Folder);
                    availabilties.Add(1, availablity1);
                    int availablity2 = CalculateWordAvailability(keyword, _dataTrain2Folder);
                    availabilties.Add(2, availablity2);

                    TrainInfo.Add(
                        new WordTrainInfo()
                        {
                            Word = keyword,
                            CategoryCount = availabilties
                        });
                }

                MessageBox.Show("فایل مقدار موثر کلمات برای داده های آموزشی ساخته شد.");

                loadKeywordsAvailability();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در عملیات: " + ex.Message);
            }

        }

        private int CalculateWordAvailability(string word, string trainFolder)
        {
            int availability = 0;

            DirectoryInfo dirInfo = new DirectoryInfo(trainFolder);
            var files = dirInfo.GetFiles().Where(f => !f.Name.EndsWith(".txt"));

            foreach (var currentFile in files)
            {
                string lineText;
                StreamReader sr = new StreamReader(currentFile.FullName);
                while ((lineText = sr.ReadLine()) != null)
                {
                    string[] words = lineText
                                         .Replace("?", " ")
                                         .Replace("/", " ")
                                         .Replace("\\", " ")
                                         .Replace("#", " ")
                                         .Replace("%", " ")
                                         .Replace("(", " ")
                                         .Replace(")", " ")
                                         .Replace("\"", " ")
                                         .Replace("*", " ")
                                         .Replace("=", " ")
                                         .Replace("+", " ")
                                         .Replace("-", " ")
                                         .Replace("^", " ")
                                         .Replace("'", " ")
                                         .Replace("`", " ")
                                         .Replace("<", " ")
                                         .Replace(">", " ")
                                         .Replace("_", " ")
                                         .Replace("$", " ")
                                         .Replace("[", " ")
                                         .Replace("]", " ")
                                         .Replace("{", " ")
                                         .Replace("}", " ")
                                         .Replace("@", " ")
                                         .Replace("|", " ")
                                         .Replace("~", " ")
                                         .Replace("!", " ")
                                         .Replace(".", " ")
                                         .Replace(",", " ")
                                         .Replace(";", " ")
                                         .Replace(":", " ")
                                         .Split(' ');

                    bool wordFound = false;
                    for (int i = 0; i < words.Length; i++)
                    {
                        string currentWord = words[i].Trim().ToLower();
                        if (currentWord.Length > 3)
                        {
                            if (currentWord == word)
                            {
                                availability++;
                                wordFound = true;
                                break;
                            }
                        }
                    }

                    if (wordFound)
                    {
                        break;
                    }
                }
            }

            return availability;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            loadKeywordsAvailability();
        }

        private void loadKeywordsAvailability()
        {
            List<ShowTrainInfo> showTrains = new List<ShowTrainInfo>();

            int i = 1;
            foreach (var item in TrainInfo)
            {
                showTrains.Add(
                    new ShowTrainInfo()
                    {
                        Index = i++,
                        Keyword = item.Word,
                        Availability1 = item.CategoryCount[1],
                        Availability2 = item.CategoryCount[2]
                    });
            }

            dataGridViewKeywordsAvailability.DataSource = showTrains;
        }

        private void buttonCalculateError_Click(object sender, EventArgs e)
        {
            int testCount = 0;
            int correctCount = 0;

            DirectoryInfo dirInfo = new DirectoryInfo(_dataTrain1Folder);
            int cat1TrainFiles = dirInfo.GetFiles().Count(f => !f.Name.EndsWith(".txt"));
            dirInfo = new DirectoryInfo(_dataTrain2Folder);
            int cat2TrainFiles = dirInfo.GetFiles().Count(f => !f.Name.EndsWith(".txt"));


            dirInfo = new DirectoryInfo(_dataTest1Folder);
            var files = dirInfo.GetFiles().Where(f => !f.Name.EndsWith(".txt"));
            foreach (var testFile in files)
            {
                if (CalculateProbability(testFile, cat1TrainFiles, cat2TrainFiles, 1))
                {
                    correctCount++;
                }

                testCount++;
            }

            dirInfo = new DirectoryInfo(_dataTest2Folder);
            files = dirInfo.GetFiles().Where(f => !f.Name.EndsWith(".txt"));
            foreach (var testFile in files)
            {
                if (CalculateProbability(testFile, cat1TrainFiles, cat2TrainFiles, 2))
                {
                    correctCount++;
                }

                testCount++;
            }

            labelError.Text = ((float)(testCount - correctCount) / testCount).ToString();
        }

        private bool CalculateProbability(FileInfo testFile, int cat1Count, int cat2Count, int targetCategory)
        {
            HashSet<string> words = new HashSet<string>();

            string lineText;
            StreamReader sr = new StreamReader(testFile.FullName);
            while ((lineText = sr.ReadLine()) != null)
            {
                string[] lineWords = lineText
                                     .Replace("?", " ")
                                     .Replace("/", " ")
                                     .Replace("\\", " ")
                                     .Replace("#", " ")
                                     .Replace("%", " ")
                                     .Replace("(", " ")
                                     .Replace(")", " ")
                                     .Replace("\"", " ")
                                     .Replace("*", " ")
                                     .Replace("=", " ")
                                     .Replace("+", " ")
                                     .Replace("-", " ")
                                     .Replace("^", " ")
                                     .Replace("'", " ")
                                     .Replace("`", " ")
                                     .Replace("<", " ")
                                     .Replace(">", " ")
                                     .Replace("_", " ")
                                     .Replace("$", " ")
                                     .Replace("[", " ")
                                     .Replace("]", " ")
                                     .Replace("{", " ")
                                     .Replace("}", " ")
                                     .Replace("@", " ")
                                     .Replace("|", " ")
                                     .Replace("~", " ")
                                     .Replace("!", " ")
                                     .Replace(".", " ")
                                     .Replace(",", " ")
                                     .Replace(";", " ")
                                     .Replace(":", " ")
                                     .Split(' ');

                for (int i = 0; i < lineWords.Length; i++)
                {
                    string currentWord = lineWords[i].Trim().ToLower();
                    if (currentWord.Length > 3)
                    {
                        words.Add(currentWord);
                    }
                }
            }

            List<decimal> wordsProbability1 = new List<decimal>();
            List<decimal> wordsProbability2 = new List<decimal>();

            foreach (var word in words)
            {
                WordTrainInfo currentTrainInfo = TrainInfo.FirstOrDefault(t => t.Word == word);
                int availability1 = 0;
                int availability2 = 0;
                if (currentTrainInfo != null)
                {
                    availability1 = currentTrainInfo.CategoryCount[1];
                    availability2 = currentTrainInfo.CategoryCount[2];
                }

                if (availability1 > 0 || availability2 > 0)
                {
                    wordsProbability1.Add(((decimal)availability1 + 1) / cat1Count);
                    wordsProbability2.Add(((decimal)availability2 + 1) / cat2Count);
                }
            }

            decimal probability1 = 1;
            foreach (var probability in wordsProbability1)
            {
                probability1 *= probability;
            }

            decimal probability2 = 1;
            foreach (var probability in wordsProbability2)
            {
                probability2 *= probability;
            }

            if (probability1 > probability2)
            {
                return targetCategory == 1;
            }
            else if (probability1 < probability2)
            {
                return targetCategory == 2;
            }
            else
            {
                return true;
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxTestFile.Text = openFileDialog1.FileName;
            }
        }

        private void buttonCalculateTestFile_Click(object sender, EventArgs e)
        {
            if (textBoxTestFile.Text.Trim() == string.Empty)
            {
                MessageBox.Show("یک فایل را انتهاب نمایید.");
                return;
            }

            DirectoryInfo dirInfo = new DirectoryInfo(_dataTrain1Folder);
            int cat1TrainFiles = dirInfo.GetFiles().Count(f => !f.Name.EndsWith(".txt"));
            dirInfo = new DirectoryInfo(_dataTrain2Folder);
            int cat2TrainFiles = dirInfo.GetFiles().Count(f => !f.Name.EndsWith(".txt"));

            FileInfo testFile = new FileInfo(textBoxTestFile.Text);
            HashSet<string> words = new HashSet<string>();

            string lineText;
            StreamReader sr = new StreamReader(testFile.FullName);
            while ((lineText = sr.ReadLine()) != null)
            {
                string[] lineWords = lineText
                                     .Replace("?", " ")
                                     .Replace("/", " ")
                                     .Replace("\\", " ")
                                     .Replace("#", " ")
                                     .Replace("%", " ")
                                     .Replace("(", " ")
                                     .Replace(")", " ")
                                     .Replace("\"", " ")
                                     .Replace("*", " ")
                                     .Replace("=", " ")
                                     .Replace("+", " ")
                                     .Replace("-", " ")
                                     .Replace("^", " ")
                                     .Replace("'", " ")
                                     .Replace("`", " ")
                                     .Replace("<", " ")
                                     .Replace(">", " ")
                                     .Replace("_", " ")
                                     .Replace("$", " ")
                                     .Replace("[", " ")
                                     .Replace("]", " ")
                                     .Replace("{", " ")
                                     .Replace("}", " ")
                                     .Replace("@", " ")
                                     .Replace("|", " ")
                                     .Replace("~", " ")
                                     .Replace("!", " ")
                                     .Replace(".", " ")
                                     .Replace(",", " ")
                                     .Replace(";", " ")
                                     .Replace(":", " ")
                                     .Split(' ');

                for (int i = 0; i < lineWords.Length; i++)
                {
                    string currentWord = lineWords[i].Trim().ToLower();
                    if (currentWord.Length > 3)
                    {
                        words.Add(currentWord);
                    }
                }
            }

            List<decimal> wordsProbability1 = new List<decimal>();
            List<decimal> wordsProbability2 = new List<decimal>();

            foreach (var word in words)
            {
                WordTrainInfo currentTrainInfo = TrainInfo.FirstOrDefault(t => t.Word == word);
                int availability1 = 0;
                int availability2 = 0;
                if (currentTrainInfo != null)
                {
                    availability1 = currentTrainInfo.CategoryCount[1];
                    availability2 = currentTrainInfo.CategoryCount[2];
                }

                if (availability1 > 0 || availability2 > 0)
                {
                    wordsProbability1.Add(((decimal)availability1 + 1) / cat1TrainFiles);
                    wordsProbability2.Add(((decimal)availability2 + 1) / cat2TrainFiles);
                }
            }

            decimal probability1 = 1;
            foreach (var probability in wordsProbability1)
            {
                probability1 *= probability;
            }

            decimal probability2 = 1;
            foreach (var probability in wordsProbability2)
            {
                probability2 *= probability;
            }

            labelProbability1.Text = probability1.ToString();
            labelProbability2.Text = probability2.ToString();

            if (probability1 > probability2)
            {
                labelSelectedCategory.Text = "Class 1";
            }
            else if (probability1 < probability2)
            {
                labelSelectedCategory.Text = "Class 2";
            }
            else
            {
                labelSelectedCategory.Text = "Class 1 or 2";
            }
        }
    }
}
