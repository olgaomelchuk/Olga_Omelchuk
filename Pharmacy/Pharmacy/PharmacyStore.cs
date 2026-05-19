using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class PharmacyStore : IEnumerable<Medicine>
    {
        public string Title { get; set; }
        public string Address { get; set; }

        private List<Medicine> medicines;

        public int Count => medicines.Count;

        public PharmacyStore(string title, string address, IEnumerable<Medicine> medicineCollection)
        {
            Title = title;
            Address = address;
            medicines = new List<Medicine>();

            foreach (var medicine in medicineCollection)
            {
                if (!medicines.Contains(medicine))
                {
                    medicines.Add(medicine);
                }
            }
        }

        public IEnumerator<Medicine> GetEnumerator() => medicines.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
