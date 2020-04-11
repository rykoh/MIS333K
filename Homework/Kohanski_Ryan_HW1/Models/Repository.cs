﻿using System.Collections.Generic;

namespace Kohanski_Ryan_HW1.Models
{
    public class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}