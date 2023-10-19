namespace API_QLHS.DTOs
{
    public class UserResponseDTO
    {

        public string Code { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }


        public UserResponseDTO(string code, string name, string phone, string email)
        {
            Code = code;
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
    public class ManagerResponseDTO
    {

        public string Code { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ManagerCode { get; set; }



        public ManagerResponseDTO(string code, string name, string phone, string email,string managerCode)
        {
            Code = code;
            Name = name;
            Phone = phone;
            Email = email;
            ManagerCode = managerCode;


        }
    }
    public class UserCreateResponseDTO
    {

        public string Code { get; set; }
        public string Name { get; set; }
      



        public UserCreateResponseDTO(string code, string name)
        {
            Code = code;
            Name = name;
       


        }
    }

}
// Test push
