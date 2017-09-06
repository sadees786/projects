using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService
{
    public class EmailToken
    {
        /// <summary>
// another comment
        /// Type name.
        /// </summary>
        public string TypeName { get; private set; }

        /// <summary>

        /// Property name.
        /// </summary>
        public string PropertyName { get; private set; }

        public EmailToken(string typeName, string propertyName)
        {
            TypeName = typeName;
            PropertyName = propertyName;
        }

        public override bool Equals(object obj)
        {
            EmailToken that;
            return
                obj != null
                && (that = obj as EmailToken) != null
                && that.ToString() == this.ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}