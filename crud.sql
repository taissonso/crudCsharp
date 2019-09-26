USE crud;

CREATE TABLE cliente (
	id int NOT NULL AUTO_INCREMENT,
	cpf VARCHAR(15),
	nome VARCHAR(151),
    rua VARCHAR(100),
    numero VARCHAR(5),
    cidade VARCHAR(100),
    numeroDePedido VARCHAR(10),
	codigo VARCHAR(10),
    quantidade VARCHAR(10),
	valor VARCHAR (10),
	descricao VARCHAR(250),
    
    PRIMARY KEY (id)
) ;