using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDeShows.DTO
{
    public class ImagemEventoDTO
    {
        public ImagemEventoDTO()
        {
        }

        public IFormFile ImagemEvento { get; set; }

        public ImagemEventoDTO(IFormFile imagemEvento)
        {
            ImagemEvento = imagemEvento;
        }
    }
}
