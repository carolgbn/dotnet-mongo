﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_mongo_api.Data.Collections
{
    public class infectado
    {
        public class Infectado
        {
            public Infectado(DateTime dataNascimento, string sexo, double latitude, double longitude)
            {
                this.DataNascimento = dataNascimento;
                this.Sexo = sexo;
                this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);
            }

            public DateTime DataNascimento { get; set; }
            public string Sexo { get; set; }
            public GeoJson2DGeographicCoordinates Localizacao { get; set; }
        }
    }