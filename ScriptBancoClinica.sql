CREATE TABLE Clientes (
    Id SERIAL PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    CPF VARCHAR(14) NOT NULL UNIQUE,
    DataNascimento DATE NOT NULL,
    Endereco VARCHAR(200),
    Telefone VARCHAR(20),
    HistoricoMedico TEXT
);
