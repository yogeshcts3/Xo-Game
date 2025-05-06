using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Mvc;
using xogame.Models;
namespace xogame.Controllers
{
    public class xoController1 : Controller
    {
        public IActionResult xoview()
        {
            Xo obj = new();
            return View(obj);
            //obj = null;
        }
        public void resetmatrix()
        {
            //Xo.xomatrix[0, 0] = 0;
            //Xo.xomatrix[0, 1] = 0;
            //Xo.xomatrix[0, 2] = 0;
            //Xo.xomatrix[1, 0] = 0;
            //Xo.xomatrix[1, 1] = 0;
            //Xo.xomatrix[1, 2] = 0;
            //Xo.xomatrix[2, 0] = 0;
            //Xo.xomatrix[2, 1] = 0;
            //Xo.xomatrix[2, 2] = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Xo.xomatrix[i, j] = 0;
                }
            }
            Xo.count = 0;
        }
        public IActionResult actiondone(int id)
        {
            //Xo obj = new();
            if(Xo.count==0) resetmatrix();
            if (id == 1 && Xo.xomatrix[0, 0] == 0)
            {
                Xo.xomatrix[0, 0] = Xo.count % 2 == 0 ? 1 : 2;
                Xo.count = Xo.count + 1;
            }
            else if (id == 2 && Xo.xomatrix[0, 1] == 0)
            {
                Xo.xomatrix[0, 1] = Xo.count % 2 == 0 ? 1 : 2;
                Xo.count = Xo.count + 1;
            }
            else if (id == 3 && Xo.xomatrix[0, 2] == 0)
            {
                Xo.xomatrix[0, 2] = Xo.count % 2 == 0 ? 1 : 2;
                Xo.count = Xo.count + 1;
            }
            else if (id == 4 && Xo.xomatrix[1, 0] == 0)
            {
                Xo.xomatrix[1, 0] = Xo.count % 2 == 0 ? 1 : 2;
                Xo.count = Xo.count + 1;
            }
            else if (id == 5 && Xo.xomatrix[1, 1] == 0)
            {
                Xo.xomatrix[1, 1] = Xo.count % 2 == 0 ? 1 : 2;
                Xo.count = Xo.count + 1;
            }
            else if (id == 6 && Xo.xomatrix[1, 2] == 0)
            {
                Xo.xomatrix[1, 2] = Xo.count % 2 == 0 ? 1 : 2;
                Xo.count = Xo.count + 1;
            }
            else if (id == 7 && Xo.xomatrix[2, 0] == 0)
            {
                Xo.xomatrix[2, 0] = Xo.count % 2 == 0 ? 1 : 2;
                Xo.count = Xo.count + 1;
            }
            else if (id == 8 && Xo.xomatrix[2, 1] == 0)
            {
                Xo.xomatrix[2, 1] = Xo.count % 2 == 0 ? 1 : 2;
                Xo.count = Xo.count + 1;
            }
            else if (id == 9 && Xo.xomatrix[2, 2] == 0)
            {
                Xo.xomatrix[2, 2] = Xo.count % 2 == 0 ? 1 : 2;
                Xo.count = Xo.count + 1;
            }
            else
            {
                //resetmatrix();
                return RedirectToAction("xoview");
            }
            if (Xo.count > 4)
            {
                var hold = new Billboard();

                if (Xo.xomatrix[0, 0] == 1 && Xo.xomatrix[0, 1] == 1 && Xo.xomatrix[0, 2] == 1)
                {
                    //Console.WriteLine(Xo.xomatrix[0, 0]);
                    resetmatrix();
                    hold.Holdstring = "Player 2 try to win next time because Player 1 is Winner";
                    return View(hold);
                }
                else if (Xo.xomatrix[0, 0] == 2 && Xo.xomatrix[0, 1] == 2 && Xo.xomatrix[0, 2] == 2)
                {
                    resetmatrix();
                    hold.Holdstring = "Player 2 is not RCB fan i think so , Because Player 2 is Winner";
                    return View(hold);
                }
                else if (Xo.xomatrix[1, 0] == 1 && Xo.xomatrix[1, 1] == 1 && Xo.xomatrix[1, 2] == 1)
                {
                    resetmatrix();
                    hold.Holdstring = "Player 2 try to win next time because Player 1 is Winner";
                    return View(hold);
                }
                else if (Xo.xomatrix[1, 0] == 2 && Xo.xomatrix[1, 1] == 2 && Xo.xomatrix[1, 2] == 2)
                {
                    resetmatrix();
                    hold.Holdstring = "Player 2 is not RCB fan i think so , Because Player 2 is Winner";
                    return View(hold);
                }
                else if (Xo.xomatrix[2, 0] == 1 && Xo.xomatrix[2, 1] == 1 && Xo.xomatrix[2, 2] == 1)
                {
                    resetmatrix();
                    hold.Holdstring = "Player 2 try to win next time because Player 1 is Winner";
                    return View(hold);
                }
                else if (Xo.xomatrix[2, 0] == 2 && Xo.xomatrix[2, 1] == 2 && Xo.xomatrix[2, 2] == 2)
                {
                    resetmatrix();
                    hold.Holdstring = "Player 2 is not RCB fan i think so , Because Player 2 is Winner";
                    return View(hold);
                }
                else if (Xo.xomatrix[0, 0] == 1 && Xo.xomatrix[1, 0] == 1 && Xo.xomatrix[2, 0] == 1)
                {
                    resetmatrix();
                    hold.Holdstring = "Player 2 try to win next time because Player 1 is Winner";
                    return View(hold);
                }
                else if (Xo.xomatrix[0, 0] == 2 && Xo.xomatrix[1, 0] == 2 && Xo.xomatrix[2, 0] == 2)
                {
                    hold.Holdstring = "Player 2 is not RCB fan i think so , Because Player 2 is Winner";
                    resetmatrix();
                    return View(hold);
                }
                else if (Xo.xomatrix[0, 1] == 1 && Xo.xomatrix[1, 1] == 1 && Xo.xomatrix[2, 1] == 1)
                {
                    resetmatrix();
                    hold.Holdstring = "Player 2 try to win next time because Player 1 is Winner";
                    return View(hold);
                }
                else if (Xo.xomatrix[0, 1] == 2 && Xo.xomatrix[1, 1] == 2 && Xo.xomatrix[2, 1] == 2)
                {
                    resetmatrix();
                    hold.Holdstring = "Player 2 is not RCB fan i think so , Because Player 2 is Winner";
                    return View(hold);
                }
                else if (Xo.xomatrix[0, 2] == 1 && Xo.xomatrix[1, 2] == 1 && Xo.xomatrix[2, 2] == 1)
                {
                    resetmatrix();
                    hold.Holdstring = "Player 2 try to win next time because Player 1 is Winner";
                    return View(hold);
                }
                else if (Xo.xomatrix[0, 2] == 2 && Xo.xomatrix[1, 2] == 2 && Xo.xomatrix[2, 2] == 2)
                {
                    resetmatrix();
                    hold.Holdstring = "Player 2 is not RCB fan i think so , Because Player 2 is Winner";
                    return View(hold);
                }
                else if (Xo.xomatrix[0, 0] == 1 && Xo.xomatrix[1, 1] == 1 && Xo.xomatrix[2, 2] == 1)
                {
                    resetmatrix();
                    hold.Holdstring = "Player 2 try to win next time because Player 1 is Winner";
                    return View(hold);
                }
                else if (Xo.xomatrix[0, 0] == 2 && Xo.xomatrix[1, 1] == 2 && Xo.xomatrix[2, 2] == 2)
                {
                    resetmatrix();
                    hold.Holdstring = "Player 2 is not RCB fan i think so , Because Player 2 is Winner";
                    return View(hold);
                }
                else if (Xo.xomatrix[0, 2] == 1 && Xo.xomatrix[1, 1] == 1 && Xo.xomatrix[2, 0] == 1)
                {
                    resetmatrix();
                    hold.Holdstring = "Player 2 try to win next time because Player 1 is Winner";
                    return View(hold);
                }
                else if (Xo.xomatrix[0, 2] == 2 && Xo.xomatrix[1, 1] == 2 && Xo.xomatrix[2, 0] == 2)
                {
                    resetmatrix();
                    hold.Holdstring = "Player 2 is not RCB fan i think so , Because Player 2 is Winner";
                    return View(hold);
                }
            }
                if(Xo.count==9)
                {
                resetmatrix();
                var hold = new Billboard();
                hold.Holdstring = "All are Equal is proved here , Give HandShake 2 each other";
                return View(hold);
                }
            //resetmatrix();
            return RedirectToAction("xoview");
        }
    }
}

