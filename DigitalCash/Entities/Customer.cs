using Moserware.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitalCash.Entities
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public SecretIdentity[] getIdentityMatrix()
        {
            string identity = "Name: "+ this.Name + "\n Address: " + this.Address;
            SecretIdentity[] secretIdentity = new SecretIdentity[100];

            for(int i=0; i<100; i++)
            {
                int j = 0;
                foreach (var currentSplit in SecretSplitter.SplitMessage(identity, 2, 2))
                {
                    if (j == 0)
                    {
                        secretIdentity[i].leftSide = currentSplit;
                        j++;
                    }
                    else
                    {
                        secretIdentity[i].rightSide = currentSplit;
                    }                   
                   
                }
            }

            return secretIdentity;
        }
    }
}