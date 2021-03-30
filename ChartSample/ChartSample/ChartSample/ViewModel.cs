using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ChartSample
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        Random random = new Random();
        public ViewModel()
        {
            Data = new ObservableCollection<Model>();

            for (int i = 1; i <= 5; i++)
            {
                Data.Add(new Model() { Category = "Jan " + i, Value = random.Next(30, 100) });
            }
        }
    }

    public class Model
    {
        public string Category { get; set; }
        public double Value { get; set; }
    }
}
