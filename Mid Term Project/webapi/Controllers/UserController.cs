using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.Modules;

namespace webapi.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
    
        public static List<User> users = new List<User>();
        public static User cur;
        public static Boolean flag = true;
        public UserController()
        {
            if (flag)
            {

                User player1 = new User { UserName = "player1", PassWord = "player1", UserId = 1, Health = 100, Food = 0, Water = 10, Wood = 0, ToolKit = 0 };
                users.Add(player1);
                flag = false;
            }


        }

        // POST api/values
        [HttpGet]
        [Route("api/[controller]")]

        public IEnumerable<User> Get()
        {
            return users;
        }

        // POST api/values
        [HttpPost]
        [Route("api/[controller]/{id}")]

        public ActionResult<int> Post(int id, LogInfo logInfo)
        {

            if (id == 1)
            {
                foreach (User u in users)
                {
                    if (String.Equals(u.UserName, logInfo.UserName) && String.Equals(u.PassWord, logInfo.PassWord))
                    {
                        cur = u;
                        return Ok(cur.UserId);
                    }
                }
                return NotFound();

            }
            else
            {
                foreach (User user in users)
                {
                    if (string.Equals(user.UserName, logInfo.UserName))
                    {
                        return NotFound();
                    }
                }
                User u = new User { UserName = logInfo.UserName, PassWord = logInfo.PassWord, UserId = users.Count, Health = 100, Food = 0, Water = 10, Wood = 0, ToolKit = 0 };
                users.Add(u);
                cur = u;
                return Ok(cur.UserId);
            }

        }

        [HttpPut]
        [Route("api/[controller]/[action]/{item}")]

        public ActionResult<User> Update(string item)
        {
            if(string.Equals(item, "toolkit"))
            {
                cur.ToolKit = 1;
                return Ok(cur);
            }
            else if(string.Equals(item, "food"))
            {
                cur.Food += 10;
                return Ok(cur);
            }
            else if (string.Equals(item, "wood"))
            {
                cur.Wood += 10;
                return Ok(cur);
            }
            else
            {
                cur.Water += 10;
                return Ok(cur);
            }
        }
    }
}