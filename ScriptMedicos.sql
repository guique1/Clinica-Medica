-- Script para criar tabela de médicos para login
CREATE TABLE IF NOT EXISTS Medicos (
    Id SERIAL PRIMARY KEY,
    Usuario VARCHAR(50) NOT NULL UNIQUE,
    Senha VARCHAR(255) NOT NULL,
    Nome VARCHAR(100) NOT NULL
);

-- Exemplo de inserção de médico (senha em texto puro, para teste; ideal é usar hash)
INSERT INTO Medicos (Usuario, Senha, Nome) VALUES ('admin', 'admin123', 'Administrador') ON CONFLICT (Usuario) DO NOTHING;
