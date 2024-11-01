namespace SignInClick.DTOS

{
public class CreateEnvelopeRequestDTOs
{
        public string Name { get; set; }
        public string Locale { get; set; } = "pt-BR"; // Definir valor padrão
        public bool AutoClose { get; set; } = true;   // Definir valor padrão
       
        public bool BlockAfterRefusal { get; set; } = true; // Definir valor padrão

        public string DeadlineAt { get; set; } // Formato ISO 8601 esperado
    }

    public class EnvelopeCreatedResponseDTO
    {
        public string EnvelopeId { get; set; }
    }

}
