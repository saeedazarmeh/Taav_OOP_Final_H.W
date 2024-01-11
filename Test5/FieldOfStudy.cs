using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    internal class FieldOfStudy
    {
        internal static List<FieldOfStudy> fields = new List<FieldOfStudy>();

        public FieldOfStudy( string name)
        {
            Name = name;
        }

        public int Id { get;protected set; }
        public string Name { get; protected set; }
        internal void SetId()
        {
            if (fields.Count > 0)
                Id = fields.Last().Id + 1;

            else Id = 1;
        }

        internal static void AddtoList(FieldOfStudy field)
        {
            fields.Add(field);
        }
    }
}
