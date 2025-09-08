-- Tabela de agendamentos (horários marcados)
CREATE TABLE IF NOT EXISTS Agendamentos (
    Id SERIAL PRIMARY KEY,
    ClienteId INTEGER NOT NULL REFERENCES Clientes(Id),
    MedicoId INTEGER NOT NULL REFERENCES Medicos(Id),
    DataHora TIMESTAMP NOT NULL,
    Observacao VARCHAR(255)
);

-- Tabela de medicamentos
CREATE TABLE IF NOT EXISTS Medicamentos (
    Id SERIAL PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Descricao VARCHAR(255)
);

-- Tabela de doenças
CREATE TABLE IF NOT EXISTS Doencas (
    Id SERIAL PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    CID VARCHAR(20),
    Descricao VARCHAR(255)
);

-- Tabela de prescrições (ligação entre cliente, medicamento e doença)
CREATE TABLE IF NOT EXISTS Prescricoes (
    Id SERIAL PRIMARY KEY,
    ClienteId INTEGER NOT NULL REFERENCES Clientes(Id),
    MedicoId INTEGER NOT NULL REFERENCES Medicos(Id),
    MedicamentoId INTEGER NOT NULL REFERENCES Medicamentos(Id),
    DoencaId INTEGER REFERENCES Doencas(Id),
    DataPrescricao TIMESTAMP NOT NULL DEFAULT NOW(),
    Observacao VARCHAR(255)
);
