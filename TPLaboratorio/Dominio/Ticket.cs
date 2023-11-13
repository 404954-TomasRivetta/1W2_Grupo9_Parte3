using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLaboratorio.Dominio
{
    public class Ticket
    {
        public int IdTicket { get; set; }
        public int IdComprobante { get; set; }
        public int IdButaca { get; set; }
        public double PreUnitario { get; set; }

        public Ticket()
        {
            IdTicket = 0;
            IdComprobante = 0;
            IdButaca = 0;
            PreUnitario = 0;
        }
        public Ticket(int com, int but, double pre, int idTicket)
        {
            IdTicket = idTicket;
            IdComprobante = com;
            IdButaca = but;
            PreUnitario = pre;
        }
    }
}
