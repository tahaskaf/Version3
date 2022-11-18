DROP DATABASE IF EXISTS T6_Juego1311;
CREATE DATABASE T6_Juego1311;
USE T6_Juego1311;

CREATE TABLE Jugador(
  id INTEGER AUTO_INCREMENT,
  usuario VARCHAR(30) NOT NULL,
  contrasena VARCHAR(80) NOT NULL,
  email VARCHAR(255) NOT NULL,
  partidas_ganadas INT,
  partidas_jugadas INT,
  conectado INTEGER,
  PRIMARY KEY (id)
)ENGINE = InnoDB;
 
CREATE TABLE Partida(
  id INT NOT NULL,
  dia VARCHAR(12),
  hora VARCHAR(10),
  matchtime INT,
  ganador VARCHAR(30),
  tablero VARCHAR(30),
  PRIMARY KEY (id)
)ENGINE = InnoDB;

CREATE TABLE Participacion(
  id_jugador INTEGER,
  id_partida INTEGER,
  posicion INTEGER,
  FOREIGN KEY (id_jugador) REFERENCES Jugador(id),
  FOREIGN KEY (id_partida) REFERENCES Partida(id) 
)ENGINE = InnoDB;


INSERT INTO Jugador(id, usuario, contrasena, email, partidas_ganadas, partidas_jugadas, conectado) VALUES (1, "Anna", '1111', 'Anna@gmail.com', 1, 2, 1);
INSERT INTO Jugador(id, usuario, contrasena, email, partidas_ganadas, partidas_jugadas, conectado) VALUES (2, "Taha", '2222', 'Taha@gmail.com', 2, 2, 1);
INSERT INTO Jugador(id, usuario, contrasena, email, partidas_ganadas, partidas_jugadas, conectado) VALUES (3, "Alex", '3333', 'Alex@gmail.com', 1, 3, 1);
INSERT INTO Jugador(id, usuario, contrasena, email, partidas_ganadas, partidas_jugadas, conectado) VALUES (4, "Juan", '4444', 'Juan@gmail.com', 1, 2, 1);

INSERT INTO Partida VALUES (1, '11/10/2022','10:20', 1, 'Anna', 'rojo');
INSERT INTO Partida VALUES (2, '11/10/2022','12:42', 2, 'Taha', 'azul');
INSERT INTO Partida VALUES (3, '11/10/2022','14:30', 1, 'Alex', 'amarillo');
INSERT INTO Partida VALUES (4, '11/10/2022','16:16', 3, 'Juan', 'verde');


INSERT INTO Participacion(id_jugador, id_partida, posicion) VALUES (1, 1, 1);
INSERT INTO Participacion(id_jugador, id_partida, posicion) VALUES (2, 1, 2);
INSERT INTO Participacion(id_jugador, id_partida, posicion) VALUES (3, 1, 3);
INSERT INTO Participacion(id_jugador, id_partida, posicion) VALUES (4, 1, 4);
INSERT INTO Participacion(id_jugador, id_partida, posicion) VALUES (1, 2, 4);
INSERT INTO Participacion(id_jugador, id_partida, posicion) VALUES (2, 2, 3);
INSERT INTO Participacion(id_jugador, id_partida, posicion) VALUES (3, 2, 2);
INSERT INTO Participacion(id_jugador, id_partida, posicion) VALUES (4, 2, 1);
