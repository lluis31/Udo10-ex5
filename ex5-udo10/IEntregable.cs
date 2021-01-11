using System;

namespace ex5_udo10
{
    internal interface IEntregable
    {
        void Entregar();
        void Devolver();
        bool Entregador();
        object CompararCon(Object a);
    }
}