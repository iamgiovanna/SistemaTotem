using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTotem
{
    internal class ItemSecretaria
    {
            [BsonId]
            [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

            public string Id { get; set; }
            public string DiaDaSemana { get; set; }
            public string Horario { get; set; }

    }
}
