using MVVM_Reg.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Reg.DataAccessLayer
{
    public class DataStorage
    {
        public ObservableCollection<UserReg> UserReg { get; set; }
        ObservableCollection<string> countryList;
        public ObservableCollection<UserReg> Load()
        {
            UserReg = new ObservableCollection<UserReg>();
            UserReg.Add(new UserReg()
            {
                Id = 1,
                Country = "India",
                Email = "abc@gmail.com",
                FirstName = "Jiya",
                LastName = "Vudeen",
                FullName = "hey",
                Language = Lanugae.Tamil,
                MobileNumer = 8098820270,
                PinCode = 621105
            });
            UserReg.Add(new UserReg()
            {
                Id = 2,
                Country = "NZ",
                Email = "abc@gmail.com",
                FirstName = "rashee",
                LastName = "Begam",
                FullName = "hey",
                Language = Lanugae.English,
                MobileNumer = 8098820270,
                PinCode = 621105
            });

            return UserReg;
        }

        public IList<string> LoadCountryList()
        {
            countryList.Add("India");
            countryList.Add("USA");
            return countryList;
        }

        public enum Lanugae
        {
            Tamil,
            English,
            Telugu
        }
    }
}
