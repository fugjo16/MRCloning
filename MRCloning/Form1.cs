using System.IO;
using static System.Net.WebRequestMethods;
using System.Text.RegularExpressions;
using File = System.IO.File;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace MRCloning
{
    public partial class Form1 : Form
    {
        string SrcPath = ".\\cloning_data";
        string SRC_MR = "MR001";
        //string FILE_HERO = "HeroConfiguration.ini";
        //string PATH_HERO = ".//test2//";

        string JSON_PATH = ".//MRCloning.json";
        static CCloningParam CloningParam;

        public Form1()
        {
            InitializeComponent();

            readJsonConfig();
            getCloningDirertory();
            if (comboBox_dir.Items.Count > 0) { comboBox_dir.SelectedIndex = 0; } 

        }
        public class CCloningParam
        {
            public string cloning_path{ get; set; }
            public string hero_file { get; set; }
            public string hero_path { get; set; }
            public string map_file { get; set; }
            public string map_path { get; set; }
            public string roadmap_file { get; set; }
            public string roadmap_path { get; set; }
        }
        public void readJsonConfig()
        {
            if (File.Exists(JSON_PATH) == false) { MessageBox.Show("JSON config read failed!"); return; }
            string jsonString = File.ReadAllText(JSON_PATH);
            CloningParam = JsonSerializer.Deserialize<CCloningParam>(jsonString);

            showJsonConfig(textBox_json);
        }
        public void showJsonConfig(TextBox josnbox)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize<CCloningParam>(CloningParam, options);
            josnbox.Text = jsonString;
        }

        private void button_start_cloning_Click(object sender, EventArgs e)
        {
            textBox_msg.Text += CloningParam.hero_file + " from " + SRC_MR + " -> " + CloningParam.hero_path + "\r\n";
            do_cloning_data(SRC_MR); // copy heroConfiguration
        }
        public void do_cloning_data(string src_mr)
        {
            SrcPath = Path.Combine(CloningParam.cloning_path, src_mr);

            // copy heroConfiguration
            do_copy_data(CloningParam.hero_file, SrcPath, CloningParam.hero_path);
        }

        public void do_copy_data(string fileName, string srcPath, string dstPath)
        {
            if (!File.Exists(Path.Combine(srcPath, fileName))) { MessageBox.Show("[ " + Path.Combine(srcPath, fileName) + " ] not exist!"); return; }

            // check directory exist
            if (Directory.Exists(dstPath) == false) { Directory.CreateDirectory(dstPath); }
            // start copy file
            File.Copy(Path.Combine(srcPath, fileName), dstPath + fileName, true);
        }

        public void getCloningDirertory()
        {
            comboBox_dir.Items.Clear();
            DirectoryInfo dirInfo = new DirectoryInfo(CloningParam.cloning_path);

            foreach (var dir in dirInfo.GetDirectories())
            {
                comboBox_dir.Items.Add(dir.Name);
            }
        }
        private void comboBox_dir_DropDown(object sender, EventArgs e)
        {
            getCloningDirertory();
        }

        private void comboBox_dir_SelectedIndexChanged(object sender, EventArgs e)
        {
            SRC_MR = comboBox_dir.SelectedItem.ToString();
            SrcPath = Path.Combine(CloningParam.cloning_path, SRC_MR);
        }

        private void button_update_dir_Click(object sender, EventArgs e)
        {
            //showJsonConfig(textBox_json);
        }
    }
}