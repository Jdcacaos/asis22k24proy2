

-- ALTERS DEL MODULO DE CONTABILIDAD 28-10-2024
ALTER TABLE tbl_cuentas

ADD COLUMN es_efectivo TINYINT DEFAULT 0 AFTER Pk_id_cuenta_enlace;
-- FIN DE ALTER 28-10-2024
    
-- Alteraciones para asegurar integridad y consistencia con el script principal

-- **1. Añadir claves primarias y auto-incrementos a las tablas referenciadas**

-- Primero, aseguramos que `tbl_recetas` tenga su clave primaria definida
ALTER TABLE `tbl_recetas`
    ADD PRIMARY KEY (`Pk_id_receta`),
    MODIFY `Pk_id_receta` int(11) NOT NULL AUTO_INCREMENT;

-- Luego, definimos la clave primaria en `tbl_cierre_produccion`
ALTER TABLE `tbl_cierre_produccion`
    ADD PRIMARY KEY (`pk_id_cierre`),
    MODIFY `pk_id_cierre` int(11) NOT NULL AUTO_INCREMENT;

-- Definimos la clave primaria en `tbl_conversiones`
ALTER TABLE `tbl_conversiones`
    ADD PRIMARY KEY (`id_conversion`),
    MODIFY `id_conversion` int(11) NOT NULL AUTO_INCREMENT;

-- Definimos la clave primaria en `tbl_mantenimientos`
ALTER TABLE `tbl_mantenimientos`
    ADD PRIMARY KEY (`Pk_id_maquinaria`),
    MODIFY `Pk_id_maquinaria` int(11) NOT NULL AUTO_INCREMENT;

-- Definimos la clave primaria en `tbl_ordenes_produccion`
ALTER TABLE `tbl_ordenes_produccion`
    ADD PRIMARY KEY (`Pk_id_orden`),
    MODIFY `Pk_id_orden` int(11) NOT NULL AUTO_INCREMENT;

-- **2. Añadir claves foráneas y índices en las tablas que referencian a otras**

-- Tabla `tbl_proceso_produccion_encabezado`
ALTER TABLE `tbl_proceso_produccion_encabezado`
    ADD PRIMARY KEY (`Pk_id_proceso`),
    MODIFY `Pk_id_proceso` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_orden` (`Fk_id_orden`),
    ADD INDEX `idx_fk_maquinaria` (`Fk_id_maquinaria`),
    ADD CONSTRAINT `fk_orden_proceso_produccion` FOREIGN KEY (`Fk_id_orden`) REFERENCES `tbl_ordenes_produccion` (`Pk_id_orden`),
    ADD CONSTRAINT `fk_maquinaria_proceso_produccion` FOREIGN KEY (`Fk_id_maquinaria`) REFERENCES `tbl_mantenimientos` (`Pk_id_maquinaria`);

-- Tabla `tbl_lotes_encabezado`
ALTER TABLE `tbl_lotes_encabezado`
    ADD PRIMARY KEY (`Pk_id_lote`),
    MODIFY `Pk_id_lote` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_proceso_lote_encabezado` (`Fk_id_proceso`),
    ADD CONSTRAINT `fk_proceso_lote_encabezado` FOREIGN KEY (`Fk_id_proceso`) REFERENCES `tbl_proceso_produccion_encabezado` (`Pk_id_proceso`);

-- Tabla `tbl_lotes_detalles`
ALTER TABLE `tbl_lotes_detalles`
    ADD PRIMARY KEY (`Pk_id_lotes_detalle`),
    MODIFY `Pk_id_lotes_detalle` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_producto` (`Fk_id_producto`),
    ADD INDEX `idx_fk_lote` (`Fk_id_lote`),
    ADD CONSTRAINT `fk_producto_lotes_detalles` FOREIGN KEY (`Fk_id_producto`) REFERENCES `Tbl_Productos` (`Pk_id_Producto`),
    ADD CONSTRAINT `fk_lote_lotes_detalles` FOREIGN KEY (`Fk_id_lote`) REFERENCES `tbl_lotes_encabezado` (`Pk_id_lote`);

-- Tabla `tbl_ordenes_produccion_detalle`
ALTER TABLE `tbl_ordenes_produccion_detalle`
    ADD PRIMARY KEY (`Pk_id_detalle`),
    MODIFY `Pk_id_detalle` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_orden` (`Fk_id_orden`),
    ADD INDEX `idx_fk_producto` (`Fk_id_producto`),
    ADD CONSTRAINT `fk_orden_detalle_produccion` FOREIGN KEY (`Fk_id_orden`) REFERENCES `tbl_ordenes_produccion` (`Pk_id_orden`),
    ADD CONSTRAINT `fk_producto_detalle_produccion` FOREIGN KEY (`Fk_id_producto`) REFERENCES `Tbl_Productos` (`Pk_id_Producto`);

-- Tabla `tbl_receta_detalle`
ALTER TABLE `tbl_receta_detalle`
    ADD PRIMARY KEY (`Pk_id_detalle`),
    MODIFY `Pk_id_detalle` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_receta` (`Fk_id_receta`),
    ADD INDEX `idx_fk_producto` (`Fk_id_producto`),
    ADD CONSTRAINT `fk_receta_detalle` FOREIGN KEY (`Fk_id_receta`) REFERENCES `tbl_recetas` (`Pk_id_receta`),
    ADD CONSTRAINT `fk_producto_receta_detalle` FOREIGN KEY (`Fk_id_producto`) REFERENCES `Tbl_Productos` (`Pk_id_Producto`);

-- Tabla `tbl_proceso_produccion_detalle`
ALTER TABLE `tbl_proceso_produccion_detalle`
    ADD PRIMARY KEY (`Pk_id_proceso_detalle`),
    MODIFY `Pk_id_proceso_detalle` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_productos` (`Fk_id_productos`),
    ADD INDEX `idx_fk_receta` (`Fk_id_receta`),
    ADD INDEX `idx_fk_empleado` (`Fk_id_empleado`),
    ADD INDEX `idx_fk_proceso` (`Fk_id_proceso`),
    ADD CONSTRAINT `fk_productos_proceso_produccion` FOREIGN KEY (`Fk_id_productos`) REFERENCES `Tbl_Productos` (`Pk_id_Producto`),
    ADD CONSTRAINT `fk_receta_proceso_produccion` FOREIGN KEY (`Fk_id_receta`) REFERENCES `tbl_recetas` (`Pk_id_receta`),
    ADD CONSTRAINT `fk_empleado_proceso_produccion` FOREIGN KEY (`Fk_id_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
    ADD CONSTRAINT `fk_proceso_produccion` FOREIGN KEY (`Fk_id_proceso`) REFERENCES `tbl_proceso_produccion_encabezado` (`Pk_id_proceso`);

-- **3. Integración de claves foráneas en tablas existentes**

-- Aseguramos que `tbl_recetas` tenga su clave primaria antes de ser referenciada
ALTER TABLE `Tbl_Productos`
    ADD COLUMN `Fk_id_receta` INT(11),
    ADD INDEX `idx_fk_receta_producto` (`Fk_id_receta`),
    ADD CONSTRAINT `fk_receta_producto` FOREIGN KEY (`Fk_id_receta`) REFERENCES `tbl_recetas` (`Pk_id_receta`);    
    
 -- Aprobado por Brandon Boch
 -- Alters de componente de producción
 -- Inicio
 -- 1. Dropeo de columnas
ALTER TABLE tbl_rrhh_produccion 
DROP COLUMN id_empleado,
DROP COLUMN id_contrato,
DROP COLUMN dias,
DROP COLUMN total_dias,
DROP COLUMN horas,
DROP COLUMN total_horas,
DROP COLUMN id_hora_extra,
DROP COLUMN total_horas_extras,
DROP COLUMN total_mano_obra,
DROP COLUMN estado;

-- 2. Se agregan las columnas
ALTER TABLE tbl_rrhh_produccion 
ADD COLUMN id_empleado INT NOT NULL,
ADD COLUMN salario DECIMAL(10, 2) NOT NULL,
ADD COLUMN dias INT NOT NULL,
ADD COLUMN total_dias DECIMAL(10, 2) NOT NULL,
ADD COLUMN horas INT NOT NULL,
ADD COLUMN total_horas DECIMAL(10, 2) NOT NULL,
ADD COLUMN horas_extras INT NOT NULL,
ADD COLUMN total_horas_extras DECIMAL(10, 2) NOT NULL,
ADD COLUMN total_mano_obra DECIMAL(10, 2) NOT NULL,
ADD COLUMN estado TINYINT(1) NOT NULL;

-- 3. Se dropea la columna id_RRHH
ALTER TABLE tbl_rrhh_produccion
DROP COLUMN id_RRHH;

-- 4. Se agrega el pk correcto
ALTER TABLE tbl_rrhh_produccion
ADD COLUMN pk_id_RRHH INT AUTO_INCREMENT PRIMARY KEY;
 -- Fin
-- ALTERS DEL MODULO DE LOGISTICA 31-10-2024
ALTER TABLE Tbl_TrasladoProductos
MODIFY costoTotal INT NOT NULL;
ALTER TABLE Tbl_TrasladoProductos
MODIFY costoTotalGeneral INT NOT NULL;
ALTER TABLE Tbl_TrasladoProductos
MODIFY precioTotal INT NOT NULL;

ALTER TABLE Tbl_TrasladoProductos
ADD COLUMN codigoProducto INT NOT NULL;

ALTER TABLE Tbl_chofer
ADD COLUMN estado TINYINT NOT NULL DEFAULT 1;
ALTER TABLE Tbl_remitente
ADD COLUMN estado TINYINT NOT NULL DEFAULT 1;
ALTER TABLE Tbl_destinatario
ADD COLUMN estado TINYINT NOT NULL DEFAULT 1;

ALTER TABLE Tbl_Productos
ADD COLUMN comisionInventario DOUBLE NOT NULL;
ALTER TABLE Tbl_Productos
ADD COLUMN comisionCosto DOUBLE NOT NULL;
ALTER TABLE Tbl_Marca
ADD COLUMN comision DOUBLE NOT NULL;
ALTER TABLE Tbl_Linea
ADD COLUMN comision DOUBLE NOT NULL;

-- ALTERS DEL MODULO DE CUENTAS CORRIENTES 31-10-2024

/*ALTER TABLE Tbl_caja_cliente
DROP COLUMN caja_deuda_monto,
DROP COLUMN caja_mora_monto,
DROP COLUMN caja_transaccion_monto;
ALTER TABLE Tbl_caja_cliente
ADD COLUMN Fk_id_factura INT NOT NULL;*/


-- NUEVOS ALTER DEL MODULO DE PRODUCCIÓN 03-11-2024 aprobado por Brandon Boch
-- 2. Alter para añadir la foránea a la tabla de mantenimiento
ALTER TABLE `tbl_mantenimientos`
ADD COLUMN `fk_id_maquina` int(11) NOT NULL;

ALTER TABLE `tbl_mantenimientos`
ADD CONSTRAINT `fk_maquina`
FOREIGN KEY (`fk_id_maquina`) REFERENCES `tbl_maquinaria`(`pk_id_maquina`);

-- NUEVOS ALTERS DEL MODULO DE CUENTAS CORRIENTES DEL 03/11/2024 
-- inica modulo de cuentas corrientes
ALTER TABLE Tbl_cobrador
CHANGE COLUMN cobrador_estado estado TINYINT DEFAULT 0 NOT NULL;

-- TBL_paises

ALTER TABLE Tbl_paises
CHANGE COLUMN pais_estado estado TINYINT DEFAULT 1 NOT NULL;

-- TBL_Formadepago

ALTER TABLE Tbl_Formadepago
CHANGE COLUMN pado_estado estado TINYINT DEFAULT 1 NOT NULL;

-- TBL_Deudas_Clientes
ALTER TABLE Tbl_Deudas_Clientes
ADD COLUMN transaccion_tipo INT NOT NULL;

ALTER TABLE Tbl_Deudas_Clientes
ADD COLUMN Fk_id_tranC INT NOT NULL,
ADD CONSTRAINT fk_id_tranC FOREIGN KEY (Fk_id_tranC) REFERENCES Tbl_transaccion_cuentas(Pk_id_tran_cue);

ALTER TABLE Tbl_Deudas_Clientes
ADD COLUMN Fk_id_factura INT NOT NULL,
ADD CONSTRAINT fk_id_factura FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura);

-- TBL_Transaccion_clientes
ALTER TABLE Tbl_Transaccion_cliente
ADD COLUMN Fk_id_factura INT NOT NULL,
ADD CONSTRAINT fk_factura_trans_cliente FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura),
ADD COLUMN Fk_id_transC INT NOT NULL,
ADD CONSTRAINT fk_transC_trans_cliente FOREIGN KEY (Fk_id_transC) REFERENCES Tbl_transaccion_cuentas(Pk_id_tran_cue),
ADD COLUMN transaccion_tipo VARCHAR(150) NOT NULL;

ALTER TABLE Tbl_Transaccion_cliente
DROP COLUMN transaccion_cuotas, 
DROP COLUMN tansaccion_cuenta;
ALTER TABLE Tbl_Transaccion_cliente DROP FOREIGN KEY tbl_transaccion_cliente_ibfk_3;

-- TBL_mora_clientes
ALTER TABLE Tbl_mora_clientes MODIFY COLUMN morafecha VARCHAR(15) NOT NULL;

-- TBL_caja_clientes

ALTER TABLE Tbl_caja_cliente MODIFY COLUMN caja_fecha_registro VARCHAR(15) NOT NULL;
ALTER TABLE Tbl_caja_cliente ADD COLUMN Fk_id_factura INT NOT NULL;
ALTER TABLE Tbl_caja_cliente ADD CONSTRAINT id_factura FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura);

ALTER TABLE Tbl_caja_cliente
DROP COLUMN caja_deuda_monto, 
DROP COLUMN caja_mora_monto, 
DROP COLUMN caja_transaccion_monto;

-- TBL_Deuda_Proveedores
ALTER TABLE Tbl_Deudas_Proveedores MODIFY COLUMN deuda_fecha_inicio VARCHAR(15) NOT NULL;
ALTER TABLE Tbl_Deudas_Proveedores MODIFY COLUMN deuda_fecha_vencimiento VARCHAR(15) NOT NULL;

ALTER TABLE Tbl_Deudas_Proveedores 
ADD COLUMN Fk_id_tranC INT NOT NULL,  
ADD CONSTRAINT fk_transaccion_cuentas FOREIGN KEY (Fk_id_tranC) REFERENCES Tbl_transaccion_cuentas(Pk_id_tran_cue), 
ADD COLUMN transaccion_tipo INT NOT NULL, 
ADD COLUMN Fk_id_factura INT NOT NULL,  
ADD CONSTRAINT fk_factura FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura);

-- TBL_Transaccion_proveedor
ALTER TABLE Tbl_Transaccion_proveedor 
ADD COLUMN Fk_id_factura INT NOT NULL,  
ADD CONSTRAINT fk_factura_trans_prov FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura), 
ADD COLUMN Fk_id_transC INT NOT NULL,  
ADD CONSTRAINT fk_transC_trans_prov FOREIGN KEY (Fk_id_transC) REFERENCES Tbl_transaccion_cuentas(Pk_id_tran_cue), 
ADD COLUMN transaccion_tipo VARCHAR(150) NOT NULL;

ALTER TABLE Tbl_Transaccion_proveedor
DROP COLUMN tansaccion_cuenta, 
DROP COLUMN tansaccion_cuotas;

ALTER TABLE Tbl_Transaccion_proveedor DROP FOREIGN KEY tbl_transaccion_proveedor_ibfk_3;

-- TBL_caja_proveedor

ALTER TABLE Tbl_caja_proveedor MODIFY COLUMN caja_fecha_registro VARCHAR(150) NOT NULL;
ALTER TABLE Tbl_caja_proveedor
ADD COLUMN Fk_id_factura INT NOT NULL,
ADD CONSTRAINT fk_factura_caja FOREIGN KEY (Fk_id_factura) REFERENCES Tbl_factura(Pk_id_factura);

ALTER TABLE Tbl_caja_proveedor
DROP COLUMN caja_deuda_monto, 
DROP COLUMN caja_transaccion_monto;


-- ALTER MODULO LOGISTICA 04/11/2024
ALTER TABLE tbl_productos ADD CONSTRAINT UQ_codigoProducto UNIQUE
(codigoProducto);

-- Alter del modulo de nominas 4/11/2024
ALTER TABLE tbl_dedu_perp_emp
ADD COLUMN dedu_perp_emp_mes VARCHAR(25) NOT NULL AFTER dedu_perp_emp_cantidad;

ALTER TABLE tbl_horas_extra
MODIFY COLUMN horas_cantidad_horas INT;

-- ALTER MODULO CONTABILIDAD 05/11/2024
ALTER TABLE tbl_historico_cuentas
ADD COLUMN estado TINYINT DEFAULT 1;