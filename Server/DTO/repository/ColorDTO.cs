using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.repository
{
    public class ColorDTO
    {
        public int ColorId { get; set; }

        public byte[] ColorName { get; set; } = null!;

    }
}
