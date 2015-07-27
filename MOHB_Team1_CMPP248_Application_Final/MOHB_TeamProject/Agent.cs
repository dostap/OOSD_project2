/* Author: Terry Mao
 * Purpose: Cause the M.O.H.B told me Workshop Part 2
 * Date: July 6, 2015
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOHB_TeamProject
{
    // make public class Agent
    public class Agent
    {
        // make public properties for access
        public Agent() { }

        public int AgentId { get; set; }

        public string AgtFirstName { get; set; }

        public string AgtMiddleInitial { get; set; }

        public string AgtLastName { get; set; }

        public string AgtBusPhone { get; set; }

        public string AgtEmail { get; set; }

        public string AgtPosition { get; set; }

        public int AgencyId { get; set; }

    }
}
