namespace SignInClick.DTOS
{
    public class CreateSignerRequestDTO
    {
        public string Name { get; set; }
        public string Birthday { get; set; } // Formato: "YYYY-MM-DD"
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool HasDocumentation { get; set; }
        public string Documentation { get; set; }
        public bool Refusable { get; set; }
        public int Group { get; set; }
        public CommunicateEventsDTO CommunicateEvents { get; set; }
    }

    public class CommunicateEventsDTO
    {
        public string DocumentSigned { get; set; }
        public string SignatureRequest { get; set; }
        public string SignatureReminder { get; set; }
    }
}
