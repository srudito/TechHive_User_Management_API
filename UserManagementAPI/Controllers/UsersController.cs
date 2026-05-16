using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Models;
using System.Text.RegularExpressions;

namespace UserManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private static List<User> users = new List<User>();

        // ✅ Email validation helper
        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        // GET: api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            try
            {
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal error: {ex.Message}");
            }
        }

        // GET: api/users/1
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            try
            {
                var user = users.FirstOrDefault(u => u.Id == id);

                if (user == null)
                    return NotFound($"User with ID {id} not found");

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST: api/users
        [HttpPost]
        public ActionResult<User> CreateUser(User newUser)
        {
            try
            {
                // ✅ Validation
                if (string.IsNullOrWhiteSpace(newUser.Name))
                    return BadRequest("Name is required");

                if (!IsValidEmail(newUser.Email))
                    return BadRequest("Invalid email format");

                if (string.IsNullOrWhiteSpace(newUser.Role))
                    return BadRequest("Role is required");

                newUser.Id = users.Count + 1;
                users.Add(newUser);

                return CreatedAtAction(nameof(GetUser), new { id = newUser.Id }, newUser);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT: api/users/1
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, User updatedUser)
        {
            try
            {
                var user = users.FirstOrDefault(u => u.Id == id);

                if (user == null)
                    return NotFound($"User with ID {id} not found");

                // ✅ Validation
                if (string.IsNullOrWhiteSpace(updatedUser.Name))
                    return BadRequest("Name is required");

                if (!IsValidEmail(updatedUser.Email))
                    return BadRequest("Invalid email format");

                if (string.IsNullOrWhiteSpace(updatedUser.Role))
                    return BadRequest("Role is required");

                user.Name = updatedUser.Name;
                user.Email = updatedUser.Email;
                user.Role = updatedUser.Role;

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE: api/users/1
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                var user = users.FirstOrDefault(u => u.Id == id);

                if (user == null)
                    return NotFound($"User with ID {id} not found");

                users.Remove(user);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
