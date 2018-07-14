using System;
using System.Collections.Generic;
using System.Text;

namespace SwtchSimplerExample
{
      public class Light
      {
          bool LightState = false;

          public void PowerOn()
          {
              CheckState(true, "The light is already turned on!", "The light is on");
          }

          public void PowerOff()
          {
              CheckState(false, "The light is already turned off!", "The light is off");
          }

          public void CheckState(bool state, string execption, string notification)
          {
              if (LightState == state)
              {
                  Console.WriteLine(execption);
              }
              else
              {
                  Console.WriteLine(notification);
                  LightState = state;
              }
          }
      }
}
