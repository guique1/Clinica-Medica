CREATE TABLE Clientes (
    Id SERIAL PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    CPF VARCHAR(14) NOT NULL UNIQUE,
    DataNascimento DATE NOT NULL,
    Endereco VARCHAR(200),
    Telefone VARCHAR(15),  -- máximo de 15 caracteres incluindo parênteses e traço
    HistoricoMedico TEXT,
    CONSTRAINT cpf_format CHECK (CPF ~ '^\d{3}\.\d{3}\.\d{3}-\d{2}$'),
    CONSTRAINT telefone_format CHECK (Telefone ~ '^\(\d{2}\) \d{4,5}-\d{4}$')
);