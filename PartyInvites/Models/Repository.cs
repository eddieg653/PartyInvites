using System.Collections.Generic;

namespace PartyInvites.Models
{
    public class Repository
    {
        // F i e l d s  &  P r o p e r t i e s

        private static List<GuestResponse> responses = new List<GuestResponse>();


        // C o n s t r u c t o r s

        // M e t h o d s

        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }

        public static List<GuestResponse> GetResponses()
        {
            return responses;
        }
         
    }
}
