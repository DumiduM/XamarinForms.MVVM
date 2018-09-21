using ListViewApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewApp.ViewModel
{
    public class Service
    {
        public List<WardModel> SeedData()
        {

            var wards = new List<WardModel>() {
            new WardModel
            {
                WardID = 01,
                WardName = "ICU"
            },
            new WardModel
            {
                WardID = 02,
                WardName = "Physical"
            },
            new WardModel
            {
                WardID = 03,
                WardName = "Mental"
            },
            new WardModel
            {
                WardID = 04,
                WardName = "Heart"
            },
            new WardModel
            {
                WardID = 01,
                WardName = "ICU"
            },
          };
            return wards;
        }
    }
}
