using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Summer.Common.Controls
{
    public class MetroSearchTextBox : MetroFramework.Controls.MetroTextBox
    {
        [System.ComponentModel.Browsable(true)]
        public string Guid { get; set; }

        public MetroSearchTextBox()
        {
            this.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);

            if (DataSource.GetInstance().Contains(Guid))
            {
                this.AutoCompleteCustomSource.Clear();
                this.AutoCompleteCustomSource.AddRange(DataSource.GetInstance().Get(Guid).ToArray());
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);

            if (!string.IsNullOrWhiteSpace(this.Text))
            {
                DataSource.GetInstance().Add(this.Guid, this.Text);
            }
        }

        public class DataSource
        {
            private string path = "AppData\\SearchTextBoxSetting.json";

            private int maxRecordCount = 20;

            private static DataSource instance = new DataSource();

            private IDictionary<string, List<string>> ds = new Dictionary<string, List<string>>();

            private DataSource()
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        this.ds = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(sr.ReadToEnd());
                    }
                }
            }

            public static DataSource GetInstance()
            {
                return instance;
            }

            public void Add(string guid, string value)
            {
                if (!ds.ContainsKey(guid))
                {
                    ds.Add(guid, new List<string>());
                }

                if (ds[guid].Take(20).Count(x => x.ToLower() == value.ToLower()) == 0)
                {
                    ds[guid].Insert(0, value);

                    if (ds[guid].Count > maxRecordCount)
                    {
                        ds[guid].RemoveRange(maxRecordCount, ds[guid].Count - maxRecordCount);
                    }

                    this.Save();
                }
            }

            public List<string> Get(string guid)
            {
                return ds[guid];
            }

            public bool Contains(string guid)
            {
                return ds.ContainsKey(guid);
            }

            public void Save()
            {
                if (!Directory.Exists(Path.GetDirectoryName(path)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                }

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(JsonConvert.SerializeObject(ds));
                }
            }
        }
    }
}
