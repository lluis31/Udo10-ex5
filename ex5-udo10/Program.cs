using System;

namespace ex5_udo10
{
    class Serie : IEntregable
    {
        private string Titulo;
        public string _Titulo { get { return Titulo; } set { Titulo = value; } }

        private int NumTemp;
        public int _NumTemp { get { return NumTemp; } set { NumTemp = value; } }

        private bool Entregado;
        public bool _Entregado { get { return Entregado; } set { Entregado = value; } }

        private string Genero;
        public string _Genero { get { return Genero; } set { Genero = value; } }

        private string Creador;
        public string _Creador { get { return Creador; } set { Creador = value; } }

        public Serie()
        {
            _Titulo = "";
            _NumTemp = 3;
            _Entregado = false;
            _Genero = "";
            _Creador = "";
        }
        public Serie(string T, string C)
        {
            _Titulo = T;
            _NumTemp = 3;
            _Entregado = false;
            _Genero = "";
            _Creador = C;
        }
        public Serie(string T, int N, string G, string C)
        {
            _Titulo = T;
            _NumTemp = N;
            _Entregado = false;
            _Genero = G;
            _Creador = C;
        }

        public override string ToString()
        {
            string a = "Titulo:" + this.Titulo + "\nNum Temp:" + this._NumTemp + "\nEntregado:" + this._Entregado + "\nGenero:" + this._Genero + "\nCreador:" + this._Creador;
            Console.WriteLine(a);
            return a;
        }
        public void Entregar()
        {
            this.Entregado = true;
        }
        public void Devolver()
        {
            this.Entregado = false;
        }
        public bool Entregador()
        {
            return this.Entregado;
        }
        public object CompararCon(Object a)
        {
            Serie A = (Serie)a;
            if (A._NumTemp > this._NumTemp)
            {
                return A;
            }
            else
            {
                return this;
            }
        }

        class Videojuego : IEntregable
        {
            private string Titulo;
            public string _Titulo { get { return Titulo; } set { Titulo = value; } }

            private int Horas;
            public int _Horas { get { return Horas; } set { Horas = value; } }

            private bool Entregado;
            public bool _Entregado { get { return Entregado; } set { Entregado = value; } }

            private string Genero;
            public string _Genero { get { return Genero; } set { Genero = value; } }

            private string Compañia;
            public string _Compañia { get { return Compañia; } set { Compañia = value; } }

            public Videojuego()
            {
                _Titulo = "";
                _Horas = 3;
                _Entregado = false;
                _Genero = "";
                _Compañia = "";
            }
            public Videojuego(string T, string C)
            {
                _Titulo = T;
                _Horas = 3;
                _Entregado = false;
                _Genero = "";
                _Compañia = C;
            }
            public Videojuego(string T, int N, string G, string C)
            {
                _Titulo = T;
                _Horas = N;
                _Entregado = false;
                _Genero = G;
                _Compañia = C;
            }

            public override string ToString()
            {
                string a = "Titulo:" + this.Titulo + "\nHoras Estimadas:" + this._Horas + "\nEntregado:" + this._Entregado + "\nGenero:" + this._Genero + "\nCompañia:" + this._Compañia;
                Console.WriteLine(a);
                return a;
            }

            public void Entregar()
            {
                this.Entregado = true;
            }
            public void Devolver()
            {
                this.Entregado = false;
            }
            public bool Entregador()
            {
                return this.Entregado;
            }
            public object CompararCon(Object a)
            {
                Videojuego A = (Videojuego)a;
                if (A._Horas > this._Horas)
                {
                    return A;
                }
                else
                {
                    return this;
                }
            }

             class Program
            {
                static void Main()
                {
                    Serie S0 = new Serie("Bola de drac", 11, "Anime", "Akira Toriyama");
                    Serie S1 = new Serie("House M.D.", 8, "Drama", "David Shore");
                    Serie S2 = new Serie("Breaking Bad", 5, "Tragedia", "Vince Gilligan");
                    Serie S3 = new Serie("Black Adder", 4, "Comedia", "Richard Curtis Rowan Atkinson");
                    Serie S4 = new Serie("House of Cards", 6, "Drama", "Beau Willimon");
                    Videojuego V0 = new Videojuego("Vampire The Masquerade. The Bloodlines", 30, "Rol", "Troika Games");
                    Videojuego V1 = new Videojuego("The Witcher 3: Wild Hunt", 220, "Rol", "CD Projekt RED");
                    Videojuego V2 = new Videojuego("Baldur's Gate 2", 80, "Rol", "Bioware Corp.");
                    Videojuego V3 = new Videojuego("Skyrim V", 75, "Rol", "Bethesda Game Studios");
                    Videojuego V4 = new Videojuego("Heroes of Might & Magic III", 20, "Estrategia", "3DO Company");
                    Serie[] Netflix = new Serie[5] { S0, S1, S2, S3, S4 };
                    Videojuego[] Steam = new Videojuego[5] { V0, V1, V2, V3, V4 };
                    S0.Entregar();
                    S2.Entregar();
                    V1.Entregar();
                    V3.Entregar();
                    int ContarSeries = 0, ContarVideojuegos = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        Netflix[i].ToString();
                        Steam[i].ToString();
                        if (Netflix[i].Entregador())
                        {
                            ContarSeries++;
                            Netflix[i].Devolver();
                        }
                        if (Steam[i].Entregador())
                        {
                            ContarVideojuegos++;
                            Steam[i].Devolver();
                        }
                    }
                    Console.WriteLine("\nSeries entregadas:{0}   Videojuegos entregados{1}", ContarSeries, ContarVideojuegos);
                    int aux = 0, aux2 = 0;
                    for (int i = 1; i < 5; i++)
                    {
                        if (Netflix[i]._NumTemp > Netflix[aux]._NumTemp)
                        {
                            aux = i;
                        }
                        if (Steam[i]._Horas > Steam[aux2]._Horas)
                        {
                            aux2 = i;
                        }

                    }
                    Console.WriteLine("La serie con más temporadas es:");
                    Netflix[aux].ToString();

                    Console.WriteLine("El videojuego con más horas estimadas es:");
                    Steam[aux2].ToString();
                }
            }
        }
    }
}