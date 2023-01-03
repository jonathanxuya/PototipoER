USE `nominas`;

DROP TABLE IF EXISTS `tbl_clientes`;
CREATE TABLE IF NOT EXISTS `tbl_clientes` (
	pk_id_cliente INT NOT NULL,
    nombre VARCHAR(80) NOT NULL,
    telefono int NOT NULL,
    email VARCHAR(25) NOT NULL,
    estado TINYINT DEFAULT 0,
    primary key (`pk_id_cliente`)
);
DROP TABLE IF EXISTS `tbl_piso`;
CREATE TABLE IF NOT EXISTS `tbl_piso` (
	pk_id_piso INT AUTO_INCREMENT NOT NULL,
    nombre VARCHAR(30) NOT NULL,
    cantidadHabitaciones int NOT NULL,
    estado TINYINT DEFAULT 0,
    primary key (`pk_id_piso`)
);
DROP TABLE IF EXISTS `tbl_habitaciones`;
CREATE TABLE IF NOT EXISTS `tbl_habitaciones` (
	pk_id_habitacion INT AUTO_INCREMENT NOT NULL,
    nombre VARCHAR(30) NOT NULL,
    cantidadCamas int NOT NULL,
    maxPersonas int NOT NULL,
    estado TINYINT DEFAULT 0,
    primary key (`pk_id_habitacion`)
);
DROP TABLE IF EXISTS `tbl_servicios`;
CREATE TABLE IF NOT EXISTS `tbl_servicios` (
	pk_id_servicios INT AUTO_INCREMENT NOT NULL,
    nombre VARCHAR(30) NOT NULL,
    estado TINYINT DEFAULT 0,
    primary key (`pk_id_servicios`)
);

DROP TABLE IF EXISTS `tbl_precio_habitacion`;
CREATE TABLE IF NOT EXISTS `tbl_precio_habitacion` (
  fk_id_habitacion INT NOT NULL,
  precio float NOT NULL,
  PRIMARY KEY (`fk_id_habitacion` ),
  FOREIGN KEY (`fk_id_habitacion`) REFERENCES `tbl_habitaciones` (`pk_id_habitacion`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS `tbl_precio_servicios`;
CREATE TABLE IF NOT EXISTS `tbl_precio_servicios` (
  fk_id_servicios INT NOT NULL,
  precio float NOT NULL,
  PRIMARY KEY (`fk_id_servicios` ),
  FOREIGN KEY (`fk_id_servicios`) REFERENCES `tbl_servicios` (`pk_id_servicios`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS `tbl_ubicacion_habitacion_piso`;
CREATE TABLE IF NOT EXISTS `tbl_ubicacion_habitacion_piso` (
  fk_id_piso INT NOT NULL, 
  fk_id_habitacion INT NOT NULL,
  PRIMARY KEY (`fk_id_piso`,`fk_id_habitacion` ),
  FOREIGN KEY (`fk_id_piso`) REFERENCES `tbl_piso` (`pk_id_piso`),
  FOREIGN KEY (`fk_id_habitacion`) REFERENCES `tbl_habitaciones` (`pk_id_habitacion`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS `tbl_asignacion_servicios_habitacion`;
CREATE TABLE IF NOT EXISTS `tbl_asignacion_servicios_habitacion` (
  fk_id_habitacion INT NOT NULL,
  fk_id_servicios INT NOT NULL,
  PRIMARY KEY (`fk_id_habitacion`,`fk_id_servicios`),
  FOREIGN KEY (`fk_id_habitacion`) REFERENCES `tbl_habitaciones` (`pk_id_habitacion`),
  FOREIGN KEY (`fk_id_servicios`) REFERENCES `tbl_servicios` (`pk_id_servicios`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS `tbl_encabezado_reservacion`;
CREATE TABLE IF NOT EXISTS `tbl_encabezado_reservacion` (
	pk_id_encabezado INT AUTO_INCREMENT NOT NULL,
    fk_id_cliente INT NOT NULL,
    fechaInicio DATE NOT NULL,
    fechaFin DATE NOT NULL,
    totalFacturado FLOAT NOT NULL,
    estado TINYINT DEFAULT 0,
    primary key (`pk_id_encabezado`),
    FOREIGN KEY (`fk_id_cliente`) REFERENCES `tbl_clientes` (`pk_id_cliente`)
);

DROP TABLE IF EXISTS `tbl_detalle_reservacion`;
CREATE TABLE IF NOT EXISTS `tbl_detalle_reservacion` (
  fk_id_reservacion INT NOT NULL,
  fk_id_habitacion INT NOT NULL,
  PRIMARY KEY (`fk_id_reservacion`,`fk_id_habitacion`),
  FOREIGN KEY (`fk_id_reservacion`) REFERENCES `tbl_encabezado_reservacion` (`pk_id_encabezado`),
  FOREIGN KEY (`fk_id_habitacion`) REFERENCES `tbl_habitaciones` (`pk_id_habitacion`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
