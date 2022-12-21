using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Application.Common.Exceptions
{
    internal class NotFoundException : Exception
    {
        public NotFoundException(string name, object key) : base($"Entity {name.ToUpper()} with id {key} not found") { }
    }
}
