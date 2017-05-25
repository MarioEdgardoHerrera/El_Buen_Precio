-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema distribuidora_el_buen_precio
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema distribuidora_el_buen_precio
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `distribuidora_el_buen_precio` DEFAULT CHARACTER SET latin1 ;
USE `distribuidora_el_buen_precio` ;

-- -----------------------------------------------------
-- Table `distribuidora_el_buen_precio`.`categorias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `distribuidora_el_buen_precio`.`categorias` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(255) NULL DEFAULT NULL,
  `descripción` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `distribuidora_el_buen_precio`.`distribuidora`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `distribuidora_el_buen_precio`.`distribuidora` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `distribuidora_el_buen_precio`.`proveedores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `distribuidora_el_buen_precio`.`proveedores` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(255) NULL DEFAULT NULL,
  `apellido` VARCHAR(255) NULL DEFAULT NULL,
  `telefono` VARCHAR(45) NULL DEFAULT NULL,
  `id_distribuidora` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_distribuidora` (`id_distribuidora` ASC),
  CONSTRAINT `fk_distribuidora`
    FOREIGN KEY (`id_distribuidora`)
    REFERENCES `distribuidora_el_buen_precio`.`distribuidora` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `distribuidora_el_buen_precio`.`producto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `distribuidora_el_buen_precio`.`producto` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nombre_producto` VARCHAR(255) NULL DEFAULT NULL,
  `proveedor_id` INT(11) NULL DEFAULT NULL,
  `precio_compra` DECIMAL(10,2) NULL DEFAULT NULL,
  `precio_venta` DECIMAL(10,2) NULL DEFAULT NULL,
  `categoria_id` INT(11) NULL DEFAULT NULL,
  `fecha_creacion` DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  INDEX `fk_categoria_art_idx` (`categoria_id` ASC),
  INDEX `fk_proveedor_prod_idx` (`proveedor_id` ASC),
  CONSTRAINT `fk_categoria_art`
    FOREIGN KEY (`categoria_id`)
    REFERENCES `distribuidora_el_buen_precio`.`categorias` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_proveedor_prod`
    FOREIGN KEY (`proveedor_id`)
    REFERENCES `distribuidora_el_buen_precio`.`proveedores` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `distribuidora_el_buen_precio`.`inventario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `distribuidora_el_buen_precio`.`inventario` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `producto_id` INT(11) NULL DEFAULT NULL,
  `cantidad` DECIMAL(10,2) NULL DEFAULT NULL,
  `frecha_agregado` DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  `total` DECIMAL(10,2) NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_producto_inv_idx` (`producto_id` ASC),
  CONSTRAINT `fk_producto_inv`
    FOREIGN KEY (`producto_id`)
    REFERENCES `distribuidora_el_buen_precio`.`producto` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `distribuidora_el_buen_precio`.`emplados`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `distribuidora_el_buen_precio`.`emplados` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `apellido` VARCHAR(45) NOT NULL,
  `telefono` VARCHAR(45) NOT NULL,
  `estado_civil` VARCHAR(45) NULL DEFAULT NULL,
  `dirección` VARCHAR(45) NOT NULL,
  `fehca_ingreso` DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  `fecha_baja` DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (`id`, `nombre`, `apellido`, `telefono`, `dirección`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `distribuidora_el_buen_precio`.`compra_productos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `distribuidora_el_buen_precio`.`compra_productos` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `emplado_id` INT(11) NULL DEFAULT NULL,
  `cantidad` DECIMAL(10,2) NULL DEFAULT NULL,
  `inventario_id` INT(11) NULL DEFAULT NULL,
  `fecha_compra` DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  `fecha_vencimiento` DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  INDEX `fk_entradas_inventario_inv_idx` (`inventario_id` ASC),
  INDEX `fk_empleado_compra_idx` (`emplado_id` ASC),
  INDEX `cantidad` (`cantidad` ASC),
  CONSTRAINT `fk_compra_productos_inv`
    FOREIGN KEY (`inventario_id`)
    REFERENCES `distribuidora_el_buen_precio`.`inventario` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_empleado_compra`
    FOREIGN KEY (`emplado_id`)
    REFERENCES `distribuidora_el_buen_precio`.`emplados` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `distribuidora_el_buen_precio`.`facturas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `distribuidora_el_buen_precio`.`facturas` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `cliente` VARCHAR(45) NULL DEFAULT NULL,
  `estado` TINYINT(1) NULL DEFAULT '0',
  `total` DECIMAL(10,2) NULL DEFAULT '0.00',
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `distribuidora_el_buen_precio`.`factura_productos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `distribuidora_el_buen_precio`.`factura_productos` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `factura_id` INT(11) NOT NULL,
  `producto_id` INT(11) NOT NULL,
  `cantidad` DECIMAL(10,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`id`),
  INDEX `fk_factura_idx` (`factura_id` ASC),
  INDEX `fk_factura_producto_idx` (`producto_id` ASC),
  CONSTRAINT `fk_factura`
    FOREIGN KEY (`factura_id`)
    REFERENCES `distribuidora_el_buen_precio`.`facturas` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_factura_producto`
    FOREIGN KEY (`producto_id`)
    REFERENCES `distribuidora_el_buen_precio`.`producto` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `distribuidora_el_buen_precio`.`usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `distribuidora_el_buen_precio`.`usuario` (
  `id_usuario` INT(255) NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(255) NULL DEFAULT NULL,
  `contra` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`id_usuario`))
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `distribuidora_el_buen_precio`.`ventas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `distribuidora_el_buen_precio`.`ventas` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `articulo_id` INT(11) NULL DEFAULT NULL,
  `cantidad` DECIMAL(10,2) NULL DEFAULT NULL,
  `total` DECIMAL(10,2) NULL DEFAULT NULL,
  `usuario_id` INT(11) NULL DEFAULT NULL,
  `fecha_venta` DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  INDEX `fk_venta_productos_inv` (`articulo_id` ASC),
  CONSTRAINT `fk_producto_venta`
    FOREIGN KEY (`articulo_id`)
    REFERENCES `distribuidora_el_buen_precio`.`producto` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = latin1;

USE `distribuidora_el_buen_precio` ;

-- -----------------------------------------------------
-- Placeholder table for view `distribuidora_el_buen_precio`.`v_vencidos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `distribuidora_el_buen_precio`.`v_vencidos` (`cantidad` INT, `inventario_id` INT, `fecha_vencimiento` INT, `producto_id` INT, `nombre_producto` INT);

-- -----------------------------------------------------
-- procedure buscar_producto
-- -----------------------------------------------------

DELIMITER $$
USE `distribuidora_el_buen_precio`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `buscar_producto`(IN `articulo` varchar(95))
BEGIN
	SELECT
producto.nombre,
producto.precio_venta,
inventario.producto_id,
inventario.cantidad
FROM
inventario
INNER JOIN producto ON inventario.producto_id = producto.id
WHERE producto.nombre = articulo;

END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure buscar_proveedor
-- -----------------------------------------------------

DELIMITER $$
USE `distribuidora_el_buen_precio`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `buscar_proveedor`(IN `proveedor_datos` varchar(95))
BEGIN
	SELECT
proveedores.id,
proveedores.nombre,
proveedores.telefono,
proveedores.id_distribuidora,
proveedores.apellido
FROM
proveedores


where 
proveedores.nombre = proveedor_datos;

END$$

DELIMITER ;

-- -----------------------------------------------------
-- View `distribuidora_el_buen_precio`.`v_vencidos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `distribuidora_el_buen_precio`.`v_vencidos`;
USE `distribuidora_el_buen_precio`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `distribuidora_el_buen_precio`.`v_vencidos` AS select `distribuidora_el_buen_precio`.`compra_productos`.`cantidad` AS `cantidad`,`distribuidora_el_buen_precio`.`compra_productos`.`inventario_id` AS `inventario_id`,`distribuidora_el_buen_precio`.`compra_productos`.`fecha_vencimiento` AS `fecha_vencimiento`,`distribuidora_el_buen_precio`.`inventario`.`producto_id` AS `producto_id`,`distribuidora_el_buen_precio`.`producto`.`nombre_producto` AS `nombre_producto` from ((`distribuidora_el_buen_precio`.`compra_productos` join `distribuidora_el_buen_precio`.`inventario` on((`distribuidora_el_buen_precio`.`compra_productos`.`inventario_id` = `distribuidora_el_buen_precio`.`inventario`.`id`))) join `distribuidora_el_buen_precio`.`producto` on((`distribuidora_el_buen_precio`.`inventario`.`producto_id` = `distribuidora_el_buen_precio`.`producto`.`id`)));
USE `distribuidora_el_buen_precio`;

DELIMITER $$
USE `distribuidora_el_buen_precio`$$
CREATE
DEFINER=`root`@`localhost`
TRIGGER `distribuidora_el_buen_precio`.`producto_AFTER_INSERT`
AFTER INSERT ON `distribuidora_el_buen_precio`.`producto`
FOR EACH ROW
BEGIN
INSERT INTO `distribuidora_el_buen_precio`.`inventario` (`producto_id`, `cantidad`) VALUES (new.id, '0');
END$$

USE `distribuidora_el_buen_precio`$$
CREATE
DEFINER=`root`@`localhost`
TRIGGER `distribuidora_el_buen_precio`.`compra_productos_AFTER_INSERT`
AFTER INSERT ON `distribuidora_el_buen_precio`.`compra_productos`
FOR EACH ROW
BEGIN
UPDATE `distribuidora_el_buen_precio`.`inventario` SET `cantidad` = `cantidad` + new.cantidad WHERE `id`=new.inventario_id ;

END$$

USE `distribuidora_el_buen_precio`$$
CREATE
DEFINER=`root`@`localhost`
TRIGGER `distribuidora_el_buen_precio`.`venta_productos`
AFTER INSERT ON `distribuidora_el_buen_precio`.`ventas`
FOR EACH ROW
BEGIN
UPDATE `distribuidora_el_buen_precio`.`inventario` SET `cantidad`= `cantidad` - new.cantidad;

END$$


DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
