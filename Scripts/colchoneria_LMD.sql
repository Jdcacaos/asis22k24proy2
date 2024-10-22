--
-- Volcado de datos para la tabla `ayuda`
--

INSERT INTO `ayuda` (`Id_ayuda`, `Ruta`, `indice`, `estado`) VALUES
(1, 'AyudaNavegador.chm', 'AyudaNav.html', 1),
(2, 'AyudaReportes.chm', 'AyudaRep.html', 1);
--
-- Volcado de datos para la tabla `factura`
--

INSERT INTO `factura` (`Pk_id_factura`, `fecha_factura`, `monto_factura`, `estado`) VALUES
(2, '2024-09-20', 100.00, NULL),
(3, '2024-09-20', 200.00, NULL),
(4, '2024-09-20', 1000.00, NULL),
(5, '2024-09-20', 233.00, 1),
(6, '2024-09-20', 1515.00, 1),
(7, '2025-03-20', 999.00, 1),
(8, '2024-09-20', 1313.00, 1),
(9, '2021-07-15', 555.00, 1),
(10, '2024-09-21', 900.00, 1);

--
-- Volcado de datos para la tabla `detallefactura`
--

INSERT INTO `detallefactura` (`Pk_id_detalle_factura`, `fk_id_factura`, `descripcion_factura`, `cantidad`, `monto_factura`, `estado`) VALUES
(1, 2, '2024-09-20', 100, 0.00, 1),
(2, 3, '2024-09-20', 200, 0.00, 1),
(3, 4, '2024-09-20', 1000, 0.00, 1),
(4, 5, '2024-09-20', 233, 0.00, 1),
(5, 6, '2024-09-20', 222, 1515.00, 1),
(6, 7, '2024-09-20', 999, 0.00, 1),
(7, 8, '2024-09-20', 300, 1313.00, 1),
(8, 9, '2024-09-20', 500, 0.00, 1),
(9, 9, '2024-09-20', 500, 0.00, 1),
(10, 10, '2024-09-21', 900, 0.00, 1),
(11, 10, '2024-09-21', 900, 0.00, 1);


--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`codigo_empleado`, `nombre_completo`, `puesto`, `departamento`, `estado`) VALUES
(1, 'JUAN GONZALEZ', 'GERENTE FINANCIERO', 'PRUEBA DEPARTAMENTO', 0),
(2, 'JOSE LUIS RODRIGUEZ', 'GERENTE COMERCIAL', 'PRUEBA DEPARTAMENTO', 1),
(3, 'JOSE FERNANDEZ', 'GERENTE DE MARKETING', 'PRUEBA DEPARTAMENTO', 0),
(4, 'MARIA GUADALUPE LOPEZ', 'DIRECTOR DE RECURSOS HUMANOS', 'PRUEBA DEPARTAMENTO', 1),
(5, 'FRANCISCO MARTINEZ', 'DIRECTOR GENERAL ', 'PRUEBA DEPARTAMENTO', 1),
(6, 'GUADALUPE SANCHEZ', 'DIRECTOR DE TECNOLOGIA', 'PRUEBA DEPARTAMENTO', 1),
(7, 'MARIA PEREZ', 'DIRECTOR EJECUTIVO', 'PRUEBA DEPARTAMENTO', 1),
(8, 'JUANA GOMEZ', 'ASISTENTE PERSONAL', 'PRUEBA DEPARTAMENTO', 1),
(9, 'ANTONIO MARTIN', 'AUXILIAR SE SERVICIOS', 'PRUEBA DEPARTAMENTO', 1),
(10, 'JESUS JIMENEZ', 'RECEPCIONISTA', 'PRUEBA DEPARTAMENTO', 1),
(11, 'MIGUEL ANGEL RUIZ', 'SECRETARIA ', 'PRUEBA DEPARTAMENTO', 1),
(12, 'PEDRO HERNANDEZ', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(13, 'ALEJANDRO DIAZ', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(14, 'MANUEL MORENO', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(15, 'MARGARITA MU?OZ', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(16, 'MARIA DEL CARMEN ALVAREZ', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(17, 'JUAN CARLOS ROMERO', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(18, 'ROBERTO ALONSO', 'RECEPCIONISTA', 'PRUEBA DEPARTAMENTO', 1),
(19, 'FERNANDO GUTIERREZ', 'RECEPCIONISTA', 'PRUEBA DEPARTAMENTO', 1),
(20, 'DANIEL NAVARRO', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(21, 'CARLOS TORRES', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(22, 'JORGE DOMINGUEZ', 'TECNICO', 'PRUEBA DEPARTAMENTO', 1),
(23, 'RICARDO VAZQUEZ', 'TECNICO', 'PRUEBA DEPARTAMENTO', 1),
(24, 'MIGUEL RAMOS', 'TECNICO', 'PRUEBA DEPARTAMENTO', 1),
(25, 'EDUARDO GIL', 'PROMOTOR', 'PRUEBA DEPARTAMENTO', 1),
(26, 'JAVIER RAMIREZ', 'ANALISTA DE VENTAS', 'PRUEBA DEPARTAMENTO', 1),
(27, 'RAFAEL SERRANO', 'DESARROLLADOR DE NEGOCIOS', 'PRUEBA DEPARTAMENTO', 1),
(28, 'MARTIN BLANCO', 'ANALISTA DE MARKETING', 'PRUEBA DEPARTAMENTO', 1),
(29, 'RAUL MOLINA', 'SUPERVISOR DE VENTAS', 'PRUEBA DEPARTAMENTO', 1),
(30, 'DAVID MORALES', 'GERENTE ADMINISTRATIVO Y FINANCIERO ', 'PRUEBA DEPARTAMENTO', 1),
(31, 'JOSEFINA SUAREZ', 'GERENTE ADMINISTRATIVO/ OPERACIONAL', 'PRUEBA DEPARTAMENTO', 1),
(32, 'JOSE ANTONIO ORTEGA', 'SUPERVISOR ADMINISTRATIVO/ OPERACIONES', 'PRUEBA DEPARTAMENTO', 1),
(33, 'ARTURO DELGADO', 'AUXILIAR ADMINISTRATIVO', 'PRUEBA DEPARTAMENTO', 1),
(34, 'MARCO ANTONIO CASTRO', 'GERENTE DEPARTAMENTAL/ SUCURSAL ', 'PRUEBA DEPARTAMENTO', 1),
(35, 'JOSE MANUEL ORTIZ', 'ANALISTA DE CONTROL DE GESTION', 'PRUEBA DEPARTAMENTO', 1),
(36, 'FRANCISCO JAVIER RUBIO', 'OPERADOR DE GARANTIAS POST VENTA', 'PRUEBA DEPARTAMENTO', 1),
(37, 'ENRIQUE MARIN', 'CONTADOR GENERAL', 'PRUEBA DEPARTAMENTO', 1),
(38, 'VERONICA SANZ', 'SUPERVISOR DE CONTABILIDAD', 'PRUEBA DEPARTAMENTO', 1),
(39, 'GERARDO NU?EZ', 'AUXILIAR CONTABLE ', 'PRUEBA DEPARTAMENTO', 1),
(40, 'MARIA ELENA IGLESIAS', 'ANALISTA DE IMPUESTOS ', 'PRUEBA DEPARTAMENTO', 1),
(41, 'LETICIA MEDINA', 'ASISTENTE DE IMPUESTOS', 'PRUEBA DEPARTAMENTO', 1),
(42, 'ROSA GARRIDO', 'ANALISTA DE COSTOS', 'PRUEBA DEPARTAMENTO', 1),
(43, 'MARIO CORTES', 'ENCARGADO DE CUENTAS A PAGAR', 'PRUEBA DEPARTAMENTO', 1),
(44, 'FRANCISCA CASTILLO', 'ENCARGADO/ AUXILIAR DE PATRIMONIO ', 'PRUEBA DEPARTAMENTO', 1),
(45, 'ALFREDO SANTOS', 'GERENTE FINANCIERO Y ADMINISTRATIVO ', 'PRUEBA DEPARTAMENTO', 1),
(46, 'TERESA LOZANO', 'GERENTE FINANCIERO', 'PRUEBA DEPARTAMENTO', 1),
(47, 'ALICIA GUERRERO', 'SUPERVISOR DE FINANZAS', 'PRUEBA DEPARTAMENTO', 1),
(48, 'MARIA FERNANDA CANO', 'ANALISTA DE FINANZAS', 'PRUEBA DEPARTAMENTO', 1),
(49, 'SERGIO PRIETO', 'ANALISTA DE FINANZAS JUNIOR ', 'PRUEBA DEPARTAMENTO', 1),
(50, 'ALBERTO MENDEZ', 'ENCARGADO DE FACTURACION Y/O CUENTAS CORRIENTES ', 'PRUEBA DEPARTAMENTO', 0),
(51, 'LUIS CRUZ', 'AUXILIAR DE FACTURACION Y/O CUENTAS CORRIENTES', 'PRUEBA DEPARTAMENTO', 1),
(52, 'ARMANDO CALVO', 'ENCARGADO DE CREDITOS', 'PRUEBA DEPARTAMENTO', 1),
(53, 'ALEJANDRA GALLEGO', 'AUXILIAR DE CREDITOS', 'PRUEBA DEPARTAMENTO', 1),
(54, 'MARTHA VIDAL', 'SUPERVISOR DE COBRANZAS', 'PRUEBA DEPARTAMENTO', 1),
(55, 'SANTIAGO LEON', 'SUPERVISOR DE TELECOBRANZAS', 'PRUEBA DEPARTAMENTO', 1),
(56, 'YOLANDA MARQUEZ', 'ENCARGADO/ AGENTE DE COBRANZAS', 'PRUEBA DEPARTAMENTO', 1),
(57, 'PATRICIA HERRERA', 'PROGRAMADOR', 'PRUEBA DEPARTAMENTO', 1),
(58, 'MARIA DE LOS ANGELES PE?A', 'AUXILIAR DE COBRANZAS', 'PRUEBA DEPARTAMENTO', 1),
(59, 'JUAN MANUEL FLORES', 'TELECOBRADOR/A JUNIOR', 'PRUEBA DEPARTAMENTO', 1),
(60, 'ROSA MARIA CABRERA', 'ANALISTA DE CREDITOS Y RIESGOS', 'PRUEBA DEPARTAMENTO', 1),
(61, 'ELIZABETH CAMPOS', 'ANALISTA DE CREDITOS Y RIESGOS JUNIOR ', 'PRUEBA DEPARTAMENTO', 1),
(62, 'GLORIA VEGA', 'TESORERO', 'PRUEBA DEPARTAMENTO', 1),
(63, 'ANGEL FUENTES', 'AUXILIAR DE TESORERIA ', 'PRUEBA DEPARTAMENTO', 1),
(64, 'GABRIELA CARRASCO', 'SUPERVISOR DE CAJAS ', 'PRUEBA DEPARTAMENTO', 1),
(65, 'SALVADOR DIEZ', 'CAJERO', 'PRUEBA DEPARTAMENTO', 1),
(66, 'VICTOR MANUEL CABALLERO', 'RECONTADOR DE BILLETES', 'PRUEBA DEPARTAMENTO', 1),
(67, 'SILVIA REYES', 'ASISTENTE PERSONAL', 'PRUEBA DEPARTAMENTO', 1),
(68, 'MARIA DE GUADALUPE NIETO', 'AUXILIAR SE SERVICIOS', 'PRUEBA DEPARTAMENTO', 1),
(69, 'MARIA DE JESUS AGUILAR', 'RECEPCIONISTA', 'PRUEBA DEPARTAMENTO', 1),
(70, 'GABRIEL PASCUAL', 'SECRETARIA ', 'PRUEBA DEPARTAMENTO', 1),
(71, 'ANDRES SANTANA', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(72, 'OSCAR HERRERO', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(73, 'GUILLERMO LORENZO', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(74, 'ANA MARIA MONTERO', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(75, 'RAMON HIDALGO', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(76, 'MARIA ISABEL GIMENEZ', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(77, 'PABLO IBALEZ', 'PROGRAMADOR', 'PRUEBA DEPARTAMENTO', 1),
(78, 'RUBEN FERRER', 'PROGRAMADOR', 'PRUEBA DEPARTAMENTO', 1),
(79, 'ANTONIA DURAN', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(80, 'MARIA LUISA SANTIAGO', 'VENDEDOR', 'PRUEBA DEPARTAMENTO', 1),
(81, 'LUIS ANGEL BENITEZ', 'TECNICO', 'PRUEBA DEPARTAMENTO', 1),
(82, 'MARIA DEL ROSARIO MORA', 'TECNICO', 'PRUEBA DEPARTAMENTO', 1),
(83, 'FELIPE VICENTE', 'TECNICO', 'PRUEBA DEPARTAMENTO', 1),
(84, 'JORGE JESUS VARGAS', 'PROMOTOR', 'PRUEBA DEPARTAMENTO', 1),
(85, 'JAIME ARIAS', 'CONSULTOR EN ADMINISTRACION DE EMPRESAS', 'PRUEBA DEPARTAMENTO', 1),
(86, 'JOSE GUADALUPE CARMONA', 'CONSULTOR AREA TECNICA ', 'PRUEBA DEPARTAMENTO', 1),
(87, 'JULIO CESAR CRESPO', 'PROGRAMADOR', 'PRUEBA DEPARTAMENTO', 1),
(88, 'JOSE DE JESUS ROMAN', 'COORDINADOR DE SISTEMAS', 'PRUEBA DEPARTAMENTO', 1),
(89, 'DIEGO PASTOR', 'ENCARGADO DE LA BASE DE DATOS', 'PRUEBA DEPARTAMENTO', 1),
(90, 'ARACELI SOTO', 'CAPACITADORES', 'PRUEBA DEPARTAMENTO', 1),
(91, 'ANDREA SAEZ', 'CIENTIFICO DE DATOS', 'PRUEBA DEPARTAMENTO', 1),
(92, 'ISABEL VELASCO', 'ANALISTA DE SEGURIDAD DE LA INFORMACION ', 'PRUEBA DEPARTAMENTO', 1),
(93, 'MARIA TERESA MOYA', 'INGENIERO DE SOFTWARE', 'PRUEBA DEPARTAMENTO', 1),
(94, 'IRMA SOLER', 'INGENIERO DE SOFTWARE', 'PRUEBA DEPARTAMENTO', 1),
(95, 'CARMEN PARRA', 'ANALISTA DE SISTMEAS COMPUTACIONALES', 'PRUEBA DEPARTAMENTO', 1),
(96, 'LUCIA ESTEBAN', 'DESARROLLADOR WEB ', 'PRUEBA DEPARTAMENTO', 1),
(97, 'ADRIANA BRAVO', 'DESARROLLADOR WEB ', 'PRUEBA DEPARTAMENTO', 1),
(98, 'AGUSTIN GALLARDO', 'DESARROLLADOR WEB ', 'PRUEBA DEPARTAMENTO', 1),
(99, 'MARIA DE LA LUZ ROJAS', 'ADMINISTRADOR DE REDES Y SISTEMAS INFORMATICOS', 'PRUEBA DEPARTAMENTO', 1),
(100, 'GUSTAVO GARCIA', 'ANALISTA DE CALIDAD', 'PRUEBA DEPARTAMENTO', 1),
(101, 'RANDY CHOC', 'ING SISTEMAS', 'IT', 1),
(102, 'GABRIEL', 'ANALISTA', 'IT', 1),
(103, 'GABRIEL', 'ING SIS', 'IT', 1),
(104, 'IRMA MONTES', 'BODEGA', 'VENTAS', 1),
(105, 'RANDALL CHOC', 'ANALISTA DE SISTEMAS', 'IT', 0),
(109, 'Edgar Casasola', 'Administrador', 'TI', 1),
(110, 'Brayan Hernandez', 'administrador', 'IT', 1),
(111, 'Josue David', 'adminsitrador', 'IT', 1),
(112, 'piki', 'Gerente', 'Ventas', 1),
(113, 'david', 'Gerente', 'Ventas', 1),
(114, 'Brayan', 'Administrador', 'IT', 1),
(115, 'qwe', 'qweq', 'qwe', 1),
(116, 'sadfa', 'asdf', 'sadf', 1),
(117, 'asdf', 'asdf', 'adf', 1),
(118, 'www', 'qwe', 'qwe', 1),
(119, 'opp', 'oppo', 'opop', 1),
(120, 'qwe', 'qweq', 'qwe', 1),
(121, 'asda', 'asd', 'asd', 1),
(122, 'asda', 'asda', 'asd', 1);


--
-- Volcado de datos para la tabla `pagos`
--

INSERT INTO `pagos` (`Pk_id_pago`, `fk_id_factura`, `fecha_pago`, `monto_factura`, `estado`) VALUES
(1, 2, '2024-09-20', 100.00, 1),
(2, 3, '2024-09-20', 200.00, 1),
(3, 4, '2024-09-20', 1000.00, 1),
(4, 5, '2024-09-20', 233.00, 1),
(5, 6, '2024-09-20', 1515.00, 1),
(6, 7, '2024-09-20', 999.00, 1),
(7, 8, '2024-09-20', 1313.00, 1),
(8, 9, '2024-09-20', 500.00, 1),
(9, 10, '2024-09-21', 900.00, 1);

--
-- Volcado de datos para la tabla `registro_empleados`
--

INSERT INTO `registro_empleados` (`codigo_registro`, `codigo_empleado`, `fecha_registro`, `hora_entrada`, `hora_salida`, `total_de_horas`, `estado`) VALUES
(1, 27, '2020-06-04', '18:19:00', '18:20:00', '00:01:00', 1),
(2, 10, '2020-06-01', '17:02:00', '18:46:00', '01:44:00', 1),
(3, 11, '2020-07-04', '18:45:00', '18:46:00', '00:01:00', 1),
(4, 12, '2020-07-04', '18:45:00', '18:46:00', '00:01:00', 1),
(5, 15, '2020-07-04', '18:45:00', '18:46:00', '00:01:00', 1),
(6, 20, '2020-06-04', '18:45:00', '18:46:00', '00:01:00', 1),
(7, 22, '2020-06-04', '18:46:00', '18:46:00', '192:00:00', 1),
(8, 40, '2020-07-04', '18:46:00', '18:46:00', '00:00:00', 1),
(9, 41, '2020-06-04', '18:46:00', '18:46:00', '00:00:00', 1),
(10, 10, '2020-06-04', '18:56:00', '19:40:00', '00:44:00', 1),
(11, 29, '2020-06-04', '20:59:00', '21:01:00', '00:02:00', 1),
(12, 12, '2020-06-04', '21:00:00', '21:01:00', '00:01:00', 1),
(13, 26, '2020-06-04', '21:19:00', '21:25:00', '00:06:00', 1),
(14, 77, '2020-05-01', '07:15:00', '10:15:00', '03:00:00', 1),
(15, 77, '2020-05-02', '07:15:00', '16:15:00', '09:00:00', 1),
(16, 77, '2020-05-03', '07:15:00', '16:15:00', '09:00:00', 1),
(17, 77, '2020-05-04', '07:15:00', '16:15:00', '09:00:00', 1),
(18, 77, '2020-05-05', '07:15:00', '16:15:00', '09:00:00', 1),
(19, 77, '2020-05-06', '07:15:00', '16:15:00', '09:00:00', 1),
(20, 77, '2020-05-07', '07:15:00', '16:15:00', '09:00:00', 1),
(21, 77, '2020-05-08', '07:15:00', '16:15:00', '09:00:00', 1),
(22, 77, '2020-05-09', '07:15:00', '16:15:00', '09:00:00', 1),
(23, 77, '2020-05-10', '07:15:00', '16:35:00', '09:20:00', 1),
(24, 77, '2020-05-11', '07:15:00', '16:15:00', '09:00:00', 1),
(25, 77, '2020-05-12', '07:15:00', '16:15:00', '09:00:00', 1),
(26, 77, '2020-05-13', '07:15:00', '16:15:00', '09:00:00', 1),
(27, 77, '2020-05-14', '07:15:00', '16:15:00', '09:00:00', 1),
(28, 77, '2020-05-15', '07:15:00', '16:15:00', '09:00:00', 1),
(29, 77, '2020-05-16', '07:15:00', '16:15:00', '09:00:00', 1),
(30, 77, '2020-05-17', '07:15:00', '16:15:00', '09:00:00', 1),
(31, 77, '2020-05-18', '07:15:00', '16:15:00', '09:00:00', 1),
(32, 77, '2020-05-19', '07:15:00', '16:15:00', '09:00:00', 1),
(33, 77, '2020-05-20', '07:15:00', '16:15:00', '09:00:00', 1),
(34, 77, '2020-05-21', '07:15:00', '16:15:00', '09:00:00', 1),
(35, 77, '2020-05-22', '07:15:00', '16:15:00', '09:00:00', 1),
(36, 77, '2020-05-23', '07:15:00', '16:15:00', '09:00:00', 1),
(37, 77, '2020-05-24', '07:15:00', '16:15:00', '09:00:00', 1),
(38, 77, '2020-05-25', '07:15:00', '16:15:00', '09:00:00', 1),
(39, 77, '2020-05-26', '07:15:00', '16:15:00', '09:00:00', 1),
(40, 77, '2020-05-27', '07:15:00', '16:15:00', '09:00:00', 1),
(41, 77, '2020-05-28', '07:15:00', '16:15:00', '09:00:00', 1),
(42, 77, '2020-05-29', '07:15:00', '16:15:00', '09:00:00', 1),
(43, 77, '2020-05-30', '07:15:00', '16:15:00', '09:00:00', 1),
(44, 77, '2020-05-31', '07:15:00', '16:15:00', '09:00:00', 1),
(45, 77, '2020-06-01', '07:15:00', '16:15:00', '09:00:00', 1),
(46, 77, '2020-06-02', '07:15:00', '16:15:00', '09:00:00', 1),
(47, 77, '2020-06-03', '07:15:00', '16:15:00', '09:00:00', 1),
(48, 77, '2020-06-04', '07:15:00', '16:15:00', '09:00:00', 1),
(49, 77, '2020-06-06', '07:15:00', '16:15:00', '09:00:00', 1),
(50, 77, '2020-06-07', '07:15:00', '16:15:00', '09:00:00', 1),
(51, 77, '2020-06-08', '07:15:00', '16:15:00', '09:00:00', 1),
(52, 77, '2020-06-09', '07:15:00', '16:15:00', '09:00:00', 1),
(53, 77, '2020-06-10', '07:15:00', '16:15:00', '09:00:00', 1),
(54, 77, '2020-06-11', '07:15:00', '16:15:00', '09:00:00', 1),
(55, 77, '2020-06-12', '07:15:00', '16:15:00', '09:00:00', 1),
(56, 77, '2020-06-13', '07:15:00', '16:15:00', '09:00:00', 1),
(57, 77, '2020-06-14', '07:15:00', '16:15:00', '09:00:00', 1),
(58, 77, '2020-06-15', '07:15:00', '16:15:00', '09:00:00', 1),
(59, 77, '2020-06-16', '07:15:00', '16:15:00', '09:00:00', 1),
(60, 77, '2020-06-17', '07:15:00', '16:15:00', '09:00:00', 1),
(61, 77, '2020-06-18', '07:15:00', '16:15:00', '09:00:00', 1),
(62, 77, '2020-06-19', '07:15:00', '16:15:00', '09:00:00', 1),
(63, 77, '2020-06-20', '07:15:00', '16:15:00', '09:00:00', 1),
(64, 77, '2020-06-21', '07:15:00', '16:15:00', '09:00:00', 1),
(65, 77, '2020-06-22', '07:15:00', '16:15:00', '09:00:00', 1),
(66, 77, '2020-06-23', '07:15:00', '16:15:00', '09:00:00', 1),
(67, 77, '2020-06-24', '07:15:00', '16:15:00', '09:00:00', 1),
(68, 77, '2020-06-25', '07:15:00', '16:15:00', '09:00:00', 1),
(69, 77, '2020-06-26', '07:15:00', '16:15:00', '09:00:00', 1),
(70, 77, '2020-06-27', '07:15:00', '16:15:00', '09:00:00', 1),
(71, 77, '2020-06-28', '07:05:00', '16:15:00', '09:10:00', 1),
(72, 77, '2020-06-29', '07:15:00', '16:15:00', '09:00:00', 1),
(73, 77, '2020-06-30', '07:15:00', '16:15:00', '09:00:00', 1),
(74, 99, '2020-06-05', '03:29:00', '18:46:00', '15:17:00', 1),
(75, 68, '2020-06-05', '19:55:00', NULL, NULL, 1),
(76, 66, '2020-06-06', '16:11:00', '16:12:00', '00:01:00', 1),
(77, 67, '2020-06-06', '16:11:00', '22:47:00', '06:36:00', 1),
(78, 104, '2020-06-06', '22:50:00', '22:54:00', '00:04:00', 1),
(79, 68, '2020-06-06', '22:54:00', '22:54:00', '00:00:00', 1),
(80, 105, '2020-06-06', '23:28:00', '23:29:00', '00:01:00', 1);


--
-- Volcado de datos para la tabla `tbl_aplicaciones`
--

INSERT INTO `tbl_aplicaciones` (`Pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(1000, 'MDI SEGURIDAD', 'PARA SEGURIDAD', 1),
(1001, 'Mant. Usuario', 'PARA SEGURIDAD', 1),
(1002, 'Mant. Aplicación', 'PARA SEGURIDAD', 1),
(1003, 'Mant. Modulo', 'PARA SEGURIDAD', 1),
(1004, 'Mant. Perfil', 'PARA SEGURIDAD', 1),
(1101, 'Asign. Modulo Aplicacion', 'PARA SEGURIDAD', 1),
(1102, 'Asign. Aplicacion Perfil', 'PARA SEGURIDAD', 1),
(1103, 'Asign. Perfil Usuario', 'PARA SEGURIDAD', 1),
(1201, 'Pcs. Cambio Contraseña', 'PARA SEGURIDAD', 1),
(1301, 'Pcs. BITACORA', 'PARA SEGURIDAD', 1),
(2000, 'MDI LOGISTICA', 'PARA LOGISTICA', 1),
(3000, 'MDI COMPRAS Y VENTAS', 'PARA COMPRAS Y VENTAS', 1),
(5000, 'MDI PRODUCCIÓN', 'PARA PRODUCCIÓN', 1),
(6000, 'MDI NOMINAS', 'PARA NOMINAS', 1),
(6001, 'Mant. Trabajadores', 'PARA NOMINAS', 1),
(6002, 'Mant. Puestos de Trabajo', 'PARA NOMINAS', 1),
(6003, 'Mant. Departamentos', 'PARA NOMINAS', 1),
(6004, 'Mant. Contratos', 'PARA NOMINAS', 1),
(6005, 'Mant. Percepciones', 'PARA NOMINAS', 1),
(6006, 'Mant. Horas Extras', 'PARA NOMINAS', 1),
(6007, 'Mant. Faltas', 'PARA NOMINAS', 1),
(6101, 'Asgn. Puesto - Depto.', 'PARA NOMINAS', 1),
(6102, 'Asgn. Puesto - Trabajador', 'PARA NOMINAS', 1),
(6103, 'Asgn. Contrato Trabajador', 'PARA NOMINAS', 1),
(6104, 'Asgn. Prestaciones Contrato', 'PARA NOMINAS', 1),
(6105, 'Asgn. Prestaciones Individual', 'PARA NOMINAS', 1),
(6106, 'Prcs. Nomina', 'PARA NOMINAS', 1),
(6201, 'Rpt. Planillas', 'PARA NOMINAS', 1),
(6202, 'Rpt. Contratos', 'PARA NOMINAS', 1),
(6203, 'Rpt. Trabajadores', 'PARA NOMINAS', 1),
(6301, 'ACCESO SEGURIDAD', 'PARA NOMINAS', 1),
(7000, 'MDI BANCOS', 'PARA BANCOS', 1),
(8000, 'MDI CONTRABILIDAD', 'PARA CONTRABILIDAD', 1);

--
-- Volcado de datos para la tabla `tbl_consultainteligente`
--

INSERT INTO `tbl_consultainteligente` (`Pk_consultaID`, `nombre_consulta`, `tipo_consulta`, `consulta_SQLE`, `consulta_estatus`) VALUES
(1, '', 0, 'SELECT id_venta FROM venta;', 1),
(2, '', 0, 'SELECT SELECT id_venta FROM venta;id_venta AS * FROM venta;', 1),
(3, '', 0, 'SELECT * FROM venta;', 1),
(4, '', 0, 'SELECT * FROM venta;', 1),
(5, '', 0, 'SELECT * FROM venta;', 1),
(6, '', 0, 'SELECT * FROM venta;', 1),
(7, 'dsf', 0, 'SELECT * FROM venta;', 1),
(8, '', 0, 'SELECT * FROM venta;', 1),
(9, '', 0, 'SELECT * FROM venta;', 1),
(10, 'viccccccccc', 0, 'SELECT * FROM venta;', 1),
(11, 'consultaaaaa', 0, 'SELECT * FROM factura;', 1),
(12, '', 0, 'SELECT * FROM factura;', 1),
(13, 'jkjkkjk', 0, 'SELECT * FROM factura;', 1);

--
-- Volcado de datos para la tabla `tbl_modulos`
--

INSERT INTO `tbl_modulos` (`Pk_id_modulos`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(1000, 'SEGURIDAD', 'Seguridad', 1),
(2000, 'LOGISTICA', 'Logistica', 1),
(3000, 'COMPRAS Y VENTAS', 'Compras y Ventas', 1),
(5000, 'PRODUCCIÓN', 'Produccion', 1),
(6000, 'NOMINAS', 'Nominas', 1),
(7000, 'BANCOS', 'Bancos', 1),
(8000, 'CONTABILIDAD', 'Contabilidad', 1);

--
-- Volcado de datos para la tabla `tbl_perfiles`
--

INSERT INTO `tbl_perfiles` (`Pk_id_perfil`, `nombre_perfil`, `descripcion_perfil`, `estado_perfil`) VALUES
(1, 'ADMINISTRADOR', 'contiene todos los permisos del programa', 1),
(2, 'SEGURIDAD', 'contiene todos los permisos de seguridad', 1),
(3, 'LOGISTICA', 'contiene todos los permisos de logistica', 1),
(4, 'COMPRAS Y VENTAS', 'contiene todos los permisos de compras y ventas', 1),
(5, 'PRODUCCIÓN', 'contiene todos los permisos de producción', 1),
(6, 'NOMINAS', 'contiene todos los permisos de nominas', 1),
(7, 'BANCOS', 'contiene todos los permisos de bancos', 1),
(8, 'CONTABILIDAD', 'contiene todos los permisos de contabilidad', 1),
(9, 'AUDITOR', 'Permite la revisión y auditoría de actividades sin capacidad de modificar datos', 1),
(10, 'SOporte Técnico', 'Permite brindar asistencia técnica sin acceso completo a la administración', 1),
(11, 'ADMINISTRADOR', 'Acceso completo al sistema con ciertas restricciones según sea necesario', 1),
(12, 'GESTOR DE PROYECTOS', 'Permite gestionar proyectos y coordinar actividades sin acceso completo a la administración', 1),
(13, 'GESTOR DE DATOS', 'Permite gestionar y supervisar datos en distintos módulos sin acceso completo a la administración', 1);


--
-- Volcado de datos para la tabla `tbl_permisos_aplicacion_perfil`
--

INSERT INTO `tbl_permisos_aplicacion_perfil` (`PK_id_Aplicacion_Perfil`, `Fk_id_perfil`, `Fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`) VALUES
(1, 1, 1000, 1, 1, 1, 1, 1),
(2, 1, 1001, 1, 1, 1, 1, 1),
(3, 1, 1002, 1, 1, 1, 1, 1),
(4, 1, 1003, 1, 1, 1, 1, 1),
(5, 1, 1004, 1, 1, 1, 1, 1),
(6, 1, 1101, 1, 1, 1, 1, 1),
(7, 1, 1102, 1, 1, 1, 1, 1),
(8, 1, 1103, 1, 1, 1, 1, 1),
(9, 1, 1201, 1, 1, 1, 1, 1),
(10, 1, 1301, 1, 1, 1, 1, 1),
(11, 1, 2000, 1, 1, 1, 1, 1),
(12, 1, 3000, 1, 1, 1, 1, 1),
(13, 1, 5000, 1, 1, 1, 1, 1),
(14, 1, 6000, 1, 1, 1, 1, 1),
(15, 1, 6001, 1, 1, 1, 1, 1),
(16, 1, 6002, 1, 1, 1, 1, 1),
(17, 1, 6003, 1, 1, 1, 1, 1),
(18, 1, 6004, 1, 1, 1, 1, 1),
(19, 1, 6005, 1, 1, 1, 1, 1),
(20, 1, 6006, 1, 1, 1, 1, 1),
(21, 1, 6007, 1, 1, 1, 1, 1),
(22, 1, 6101, 1, 1, 1, 1, 1),
(23, 1, 6102, 1, 1, 1, 1, 1),
(24, 1, 6103, 1, 1, 1, 1, 1),
(25, 1, 6104, 1, 1, 1, 1, 1),
(26, 1, 6105, 1, 1, 1, 1, 1),
(27, 1, 6106, 1, 1, 1, 1, 1),
(28, 1, 6201, 1, 1, 1, 1, 1),
(29, 1, 6202, 1, 1, 1, 1, 1),
(30, 1, 6203, 1, 1, 1, 1, 1),
(31, 1, 6301, 1, 1, 1, 1, 1),
(32, 1, 7000, 1, 1, 1, 1, 1),
(33, 1, 8000, 1, 1, 1, 1, 1),
(34, 2, 1000, 1, 1, 1, 1, 1),
(35, 3, 2000, 1, 1, 1, 1, 1),
(36, 4, 3000, 1, 1, 1, 1, 1),
(37, 5, 5000, 1, 1, 1, 1, 1),
(38, 6, 6000, 1, 1, 1, 1, 1),
(39, 6, 6001, 1, 1, 1, 1, 1),
(40, 6, 6002, 1, 1, 1, 1, 1),
(41, 6, 6003, 1, 1, 1, 1, 1),
(42, 6, 6004, 1, 1, 1, 1, 1),
(43, 6, 6005, 1, 1, 1, 1, 1),
(44, 6, 6006, 1, 1, 1, 1, 1),
(45, 6, 6007, 1, 1, 1, 1, 1),
(46, 6, 6101, 1, 1, 1, 1, 1),
(47, 6, 6102, 1, 1, 1, 1, 1),
(48, 6, 6103, 1, 1, 1, 1, 1),
(49, 6, 6104, 1, 1, 1, 1, 1),
(50, 6, 6105, 1, 1, 1, 1, 1),
(51, 6, 6106, 1, 1, 1, 1, 1),
(52, 6, 6201, 1, 1, 1, 1, 1),
(53, 6, 6202, 1, 1, 1, 1, 1),
(54, 6, 6203, 1, 1, 1, 1, 1),
(55, 6, 6301, 1, 1, 1, 1, 1),
(56, 7, 7000, 1, 1, 1, 1, 1),
(57, 8, 8000, 1, 1, 1, 1, 1),
(58, 9, 1000, 1, 1, 1, 1, 1),
(59, 9, 1001, 1, 1, 1, 1, 1),
(60, 9, 1002, 1, 1, 1, 1, 1),
(61, 9, 1003, 1, 1, 1, 1, 1),
(62, 9, 1004, 1, 1, 1, 1, 1),
(63, 9, 1101, 1, 1, 1, 1, 1),
(64, 9, 1102, 1, 1, 1, 1, 1),
(65, 9, 1103, 1, 1, 1, 1, 1),
(66, 9, 1201, 1, 1, 1, 1, 1),
(67, 9, 1301, 1, 1, 1, 1, 1),
(68, 9, 2000, 1, 1, 1, 1, 1),
(69, 9, 3000, 1, 1, 1, 1, 1),
(70, 9, 5000, 1, 1, 1, 1, 1),
(71, 9, 6000, 1, 1, 1, 1, 1),
(72, 9, 6001, 1, 1, 1, 1, 1),
(73, 9, 6002, 1, 1, 1, 1, 1),
(74, 9, 6003, 1, 1, 1, 1, 1),
(75, 9, 6004, 1, 1, 1, 1, 1),
(76, 9, 6005, 1, 1, 1, 1, 1),
(77, 9, 6006, 1, 1, 1, 1, 1),
(78, 9, 6007, 1, 1, 1, 1, 1),
(79, 9, 6101, 1, 1, 1, 1, 1),
(80, 9, 6102, 1, 1, 1, 1, 1),
(81, 9, 6103, 1, 1, 1, 1, 1),
(82, 9, 6104, 1, 1, 1, 1, 1),
(83, 9, 6105, 1, 1, 1, 1, 1),
(84, 9, 6106, 1, 1, 1, 1, 1),
(85, 9, 6201, 1, 1, 1, 1, 1),
(86, 9, 6202, 1, 1, 1, 1, 1),
(87, 9, 6203, 1, 1, 1, 1, 1),
(88, 9, 6301, 1, 1, 1, 1, 1),
(89, 9, 7000, 1, 1, 1, 1, 1),
(90, 9, 8000, 1, 1, 1, 1, 1),
(91, 10, 1000, 1, 1, 1, 1, 1),
(92, 10, 1001, 1, 1, 1, 1, 1),
(93, 10, 1002, 1, 1, 1, 1, 1),
(94, 10, 1003, 1, 1, 1, 1, 1),
(95, 10, 1004, 1, 1, 1, 1, 1),
(96, 10, 1101, 1, 1, 1, 1, 1),
(97, 10, 1102, 1, 1, 1, 1, 1),
(98, 10, 1103, 1, 1, 1, 1, 1),
(99, 10, 1201, 1, 1, 1, 1, 1),
(100, 10, 1301, 1, 1, 1, 1, 1),
(101, 10, 2000, 1, 1, 1, 1, 1),
(102, 10, 3000, 1, 1, 1, 1, 1),
(103, 10, 5000, 1, 1, 1, 1, 1),
(104, 10, 6000, 1, 1, 1, 1, 1),
(105, 10, 6001, 1, 1, 1, 1, 1),
(106, 10, 6002, 1, 1, 1, 1, 1),
(107, 10, 6003, 1, 1, 1, 1, 1),
(108, 10, 6004, 1, 1, 1, 1, 1),
(109, 10, 6005, 1, 1, 1, 1, 1),
(110, 10, 6006, 1, 1, 1, 1, 1),
(111, 10, 6007, 1, 1, 1, 1, 1),
(112, 10, 6101, 1, 1, 1, 1, 1),
(113, 10, 6102, 1, 1, 1, 1, 1),
(114, 10, 6103, 1, 1, 1, 1, 1),
(115, 10, 6104, 1, 1, 1, 1, 1),
(116, 10, 6105, 1, 1, 1, 1, 1),
(117, 10, 6106, 1, 1, 1, 1, 1),
(118, 10, 6201, 1, 1, 1, 1, 1),
(119, 10, 6202, 1, 1, 1, 1, 1),
(120, 10, 6203, 1, 1, 1, 1, 1),
(121, 10, 6301, 1, 1, 1, 1, 1),
(122, 10, 7000, 1, 1, 1, 1, 1),
(123, 10, 8000, 1, 1, 1, 1, 1),
(124, 11, 1000, 1, 1, 1, 1, 1),
(125, 11, 1001, 1, 1, 1, 1, 1),
(126, 11, 1002, 1, 1, 1, 1, 1),
(127, 11, 1003, 1, 1, 1, 1, 1),
(128, 11, 1004, 1, 1, 1, 1, 1),
(129, 11, 1101, 1, 1, 1, 1, 1),
(130, 11, 1102, 1, 1, 1, 1, 1),
(131, 11, 1103, 1, 1, 1, 1, 1),
(132, 11, 1201, 1, 1, 1, 1, 1),
(133, 11, 1301, 1, 1, 1, 1, 1),
(134, 11, 2000, 1, 1, 1, 1, 1),
(135, 11, 3000, 1, 1, 1, 1, 1),
(136, 11, 5000, 1, 1, 1, 1, 1),
(137, 11, 6000, 1, 1, 1, 1, 1),
(138, 11, 6001, 1, 1, 1, 1, 1),
(139, 11, 6002, 1, 1, 1, 1, 1),
(140, 11, 6003, 1, 1, 1, 1, 1),
(141, 11, 6004, 1, 1, 1, 1, 1),
(142, 11, 6005, 1, 1, 1, 1, 1),
(143, 11, 6006, 1, 1, 1, 1, 1),
(144, 11, 6007, 1, 1, 1, 1, 1),
(145, 11, 6101, 1, 1, 1, 1, 1),
(146, 11, 6102, 1, 1, 1, 1, 1),
(147, 11, 6103, 1, 1, 1, 1, 1),
(148, 11, 6104, 1, 1, 1, 1, 1),
(149, 11, 6105, 1, 1, 1, 1, 1),
(150, 11, 6106, 1, 1, 1, 1, 1),
(151, 11, 6201, 1, 1, 1, 1, 1),
(152, 11, 6202, 1, 1, 1, 1, 1),
(153, 11, 6203, 1, 1, 1, 1, 1),
(154, 11, 6301, 1, 1, 1, 1, 1),
(155, 11, 7000, 1, 1, 1, 1, 1),
(156, 11, 8000, 1, 1, 1, 1, 1),
(157, 12, 1000, 1, 1, 1, 1, 1),
(158, 12, 1001, 1, 1, 1, 1, 1),
(159, 12, 1002, 1, 1, 1, 1, 1),
(160, 12, 1003, 1, 1, 1, 1, 1),
(161, 12, 1004, 1, 1, 1, 1, 1),
(162, 12, 1101, 1, 1, 1, 1, 1),
(163, 12, 1102, 1, 1, 1, 1, 1),
(164, 12, 1103, 1, 1, 1, 1, 1),
(165, 12, 1201, 1, 1, 1, 1, 1),
(166, 12, 1301, 1, 1, 1, 1, 1),
(167, 12, 2000, 1, 1, 1, 1, 1),
(168, 12, 3000, 1, 1, 1, 1, 1),
(169, 12, 5000, 1, 1, 1, 1, 1),
(170, 12, 6000, 1, 1, 1, 1, 1),
(171, 12, 6001, 1, 1, 1, 1, 1),
(172, 12, 6002, 1, 1, 1, 1, 1),
(173, 12, 6003, 1, 1, 1, 1, 1),
(174, 12, 6004, 1, 1, 1, 1, 1),
(175, 12, 6005, 1, 1, 1, 1, 1),
(176, 12, 6006, 1, 1, 1, 1, 1),
(177, 12, 6007, 1, 1, 1, 1, 1),
(178, 12, 6101, 1, 1, 1, 1, 1),
(179, 12, 6102, 1, 1, 1, 1, 1),
(180, 12, 6103, 1, 1, 1, 1, 1),
(181, 12, 6104, 1, 1, 1, 1, 1),
(182, 12, 6105, 1, 1, 1, 1, 1),
(183, 12, 6106, 1, 1, 1, 1, 1),
(184, 12, 6201, 1, 1, 1, 1, 1),
(185, 12, 6202, 1, 1, 1, 1, 1),
(186, 12, 6203, 1, 1, 1, 1, 1),
(187, 12, 6301, 1, 1, 1, 1, 1),
(188, 12, 7000, 1, 1, 1, 1, 1),
(189, 12, 8000, 1, 1, 1, 1, 1),
(190, 13, 1000, 1, 1, 1, 1, 1),
(191, 13, 1001, 1, 1, 1, 1, 1),
(192, 13, 1002, 1, 1, 1, 1, 1),
(193, 13, 1003, 1, 1, 1, 1, 1),
(194, 13, 1004, 1, 1, 1, 1, 1),
(195, 13, 1101, 1, 1, 1, 1, 1),
(196, 13, 1102, 1, 1, 1, 1, 1),
(197, 13, 1103, 1, 1, 1, 1, 1),
(198, 13, 1201, 1, 1, 1, 1, 1),
(199, 13, 1301, 1, 1, 1, 1, 1),
(200, 13, 2000, 1, 1, 1, 1, 1),
(201, 13, 3000, 1, 1, 1, 1, 1),
(202, 13, 5000, 1, 1, 1, 1, 1),
(203, 13, 6000, 1, 1, 1, 1, 1),
(204, 13, 6001, 1, 1, 1, 1, 1),
(205, 13, 6002, 1, 1, 1, 1, 1),
(206, 13, 6003, 1, 1, 1, 1, 1),
(207, 13, 6004, 1, 1, 1, 1, 1),
(208, 13, 6005, 1, 1, 1, 1, 1),
(209, 13, 6006, 1, 1, 1, 1, 1),
(210, 13, 6007, 1, 1, 1, 1, 1),
(211, 13, 6101, 1, 1, 1, 1, 1),
(212, 13, 6102, 1, 1, 1, 1, 1),
(213, 13, 6103, 1, 1, 1, 1, 1),
(214, 13, 6104, 1, 1, 1, 1, 1),
(215, 13, 6105, 1, 1, 1, 1, 1),
(216, 13, 6106, 1, 1, 1, 1, 1),
(217, 13, 6201, 1, 1, 1, 1, 1),
(218, 13, 6202, 1, 1, 1, 1, 1),
(219, 13, 6203, 1, 1, 1, 1, 1),
(220, 13, 6301, 1, 1, 1, 1, 1),
(221, 13, 7000, 1, 1, 1, 1, 1),
(222, 13, 8000, 1, 1, 1, 1, 1);

--
-- Volcado de datos para la tabla `tbl_usuarios`
--

INSERT INTO `tbl_usuarios` (`Pk_id_usuario`, `nombre_usuario`, `apellido_usuario`, `username_usuario`, `password_usuario`, `email_usuario`, `ultima_conexion_usuario`, `estado_usuario`, `pregunta`, `respuesta`) VALUES
(1, 'admin', 'admin', 'admin', '52c88f064ed5ed9161d01f634f5e3bfcf5c77fec94fb398b6690e1b41178eb6c', 'esduardo@gmail.com', '2024-09-21 00:55:40', 1, 'COLOR FAVORITO', 'ROJO'),
(2, 'Ismar', 'Cortez', 'Ismar', 'ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f', 'icortezs@miumg.edu.gt', '2024-09-17 17:32:03', 1, 'Nombre de familiar', 'Eunice');

--
-- Volcado de datos para la tabla `tbl_asignaciones_perfils_usuario`
--

INSERT INTO `tbl_asignaciones_perfils_usuario` (`PK_id_Perfil_Usuario`, `Fk_id_usuario`, `Fk_id_perfil`) VALUES
(1, 1, 1);

--
-- Volcado de datos para la tabla `tbl_asignacion_modulo_aplicacion`
--

INSERT INTO `tbl_asignacion_modulo_aplicacion` (`Fk_id_modulos`, `Fk_id_aplicacion`) VALUES
(1000, 1000),
(1000, 1001),
(1000, 1002),
(1000, 1003),
(1000, 1004),
(1000, 1102),
(1000, 1103),
(1000, 1201),
(1000, 1301),
(2000, 2000),
(3000, 3000),
(5000, 5000),
(6000, 6000),
(6000, 6001),
(6000, 6002),
(6000, 6003),
(6000, 6004),
(6000, 6005),
(6000, 6006),
(6000, 6007),
(6000, 6101),
(6000, 6102),
(6000, 6103),
(6000, 6104),
(6000, 6105),
(6000, 6106),
(6000, 6201),
(6000, 6202),
(6000, 6203),
(6000, 6301),
(7000, 7000),
(8000, 8000);

--
-- Volcado de datos para la tabla `tbl_permisos_aplicaciones_usuario`
--

INSERT INTO `tbl_permisos_aplicaciones_usuario` (`PK_id_Aplicacion_Usuario`, `Fk_id_usuario`, `Fk_id_aplicacion`, `guardar_permiso`, `buscar_permiso`, `modificar_permiso`, `eliminar_permiso`, `imprimir_permiso`) VALUES
(1, 1, 1002, 1, 1, 1, 1, 0),
(2, 1, 2000, 0, 0, 0, 0, 0),
(3, 1, 1000, 1, 1, 1, 1, 1),
(4, 1, 8000, 0, 0, 0, 0, 0),
(6, 1, 1000, 1, 1, 1, 1, 1),
(7, 1, 1000, 0, 0, 0, 0, 1);


-- Se actualiza la contraseña de admin, ya que no debe ingresarse hasheado manualmente
UPDATE `tbl_usuarios` SET `password_usuario` = 'HO0aGo4nM94=' WHERE `Pk_id_usuario` = 1;

-- Se eliminó el usuario 2 porque solo el admin debe crearse desde la base de datos
DELETE FROM `tbl_usuarios` WHERE `Pk_id_usuario` = 2;

-- Se hashea la contraseña
UPDATE tbl_usuarios
SET password_usuario = SHA2('HO0aGo4nM94=', 256) 
WHERE username_usuario = 'admin';
--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`id_venta`, `monto`, `nombre_cliente`, `nombre_empleado`, `estado`) VALUES
(1, 111, 'Josue', 'David', 1),
(2, 222, 'Fernando', 'David', 1),
(3, 100, 'Josue David', 'Joel Lopez', 1),
(4, 400, 'Sebastian', 'Victor', 1),
(5, 555, 'Brayan', 'Daniel', 1),
(6, 8888, 'pedro', 'perez', 1),
(7, 555, 'roro', 'pablo', 1),
(8, 444, 'shiro', 'rodolfo', 1),
(9, 999, 'Brayan', 'Daniel', 1),
(10, 111, 'shiro', 'sh', 1),
(11, 88, 'lol', 'lol', 1),
(12, 1111, 'lll', 'lll', 1),
(13, 1111, 'www', 'www', 1),
(14, 56456, 'wwww', 'qqq', 1),
(15, 111223, 'hola', 'hol', 1),
(16, 2222, 'yy', 'yyy', 1),
(17, 555, 'ggg', 'ggg', 1),
(18, 100, 'ahora', 'ddd', 1),
(19, 100, 'pedro', 'lucas', 1),
(20, 555, 'cliente', 'empleado', 1),
(21, 200, 'cliente', 'empleado', 1),
(22, 200, 'rrr', 'www', 1),
(23, 333, 'www', 'qqq', 1),
(24, 33, 'eee', 'xxx', 1),
(25, 600, 'ññ', 'lll', 1),
(26, 6456, 'qqq', 'fff', 1),
(27, 555, 'ddd', 'aaa', 1),
(28, 666, 'qqq', 'aaa', 1),
(29, 666, 'cliente', 'empleado', 1),
(30, 888, 'Cliente1', 'Empleado122', 1),
(31, 6666, 'ClientePrueba', 'EmpleadoPrueba', 1),
(32, 6666, 'qq', 'qqq', 1),
(33, 999, 'cliente', 'emple', 1),
(34, 333, 'cli', 'emp', 1),
(35, 65, 'pedro', 'juan', 1),
(36, 65656, 'djf', 'kjk', 1),
(37, 0, '', '', 1),
(38, 0, '', '', 1);


-- DATOS DE LAS TABLAS MAESTRAS DE CUENTAS CORRIENTES
-- Insertar datos en Tbl_vendedor
INSERT INTO `Tbl_vendedor` (nombre_vendedor, direccion_vendedor, telefono_vendedor, departamento_vendedor, estado_vendedor)
VALUES
('Juan Pérez', 'Calle Martí 112-62', 12345678, 'Ventas', 1),
('María Gómez', 'Av. Siempre Viva 456', 98765432, 'Ventas',1);

-- Insertar datos en Tbl_clientes
INSERT INTO `Tbl_clientes` (Fk_id_vendedor, nombre_cliente, telefono_cliente, direccion_cliente, saldo_cuenta, estado_cliente)
VALUES
(1, 'Carlos Ruiz', 23456789, 'Calle 10', 0, 1),  -- Habilitado
(1, 'Lucía Martínez', 34567890, 'Calle 20', 0, 0);  -- Inhabilitado

-- Insertar datos en Tbl_cobrador
INSERT INTO `Tbl_cobrador` (nombre_cobrador, direccion_cobrador, telefono_cobrador, departamento_cobrador, estado_cobrador)
VALUES
('Jorge López', 'Calle 5', 45678901, 'Cobranzas', 1),
('Ana Fernández', 'Calle 15', 56789014, 'Cobranzas', 0);

-- Insertar datos en Tbl_paises
INSERT INTO `Tbl_paises` (nombre_pais, region_pais, estatus_pais)
VALUES
('Argentina', 'Sudamérica', 1),
('México', 'América del Norte', 1);

SELECT * FROM tbl_paises;
-- Insertar datos en Tbl_tipodepago
INSERT INTO `Tbl_tipodepago` (nombre_pago, tipo_moneda, estado_pago)
VALUES
('Efectivo', 'USD', '1'),
('Tarjeta de Crédito', 'Quetrzales', 1),
('Tarjeta de Débito', 'Quetrzales', 1),
('Transferencia', 'Quetzales', 1);

-- Insertar datos en Tbl_Deudas_Cliente
INSERT INTO `Tbl_Deudas_Clientes` (Fk_id_cliente, Fk_id_cobrador, Fk_id_pago, monto_deuda, fecha_inicio_deuda, 
fecha_vencimiento_deuda, descripcion_deuda, estado_deuda)
VALUES
(1, 1, 1, 500.00, '2024-01-01', '2024-12-31', 'Deuda por compra de productos', 0),  -- Inhabilitado 
(2, 2, 2, 300.00, '2024-02-01', '2024-11-30', 'Deuda por servicios', 1);  -- Habilitado 

-- Insertar datos en Tbl_Transaccion_cliente
INSERT INTO `Tbl_Transaccion_cliente` (Fk_id_cliente, Fk_id_pais, fecha_transaccion, cuenta_tansaccion, cuotas_transaccion, 
Fk_id_deuda, monto_deuda, monto_transaccion, saldo_pendiente, Fk_id_pago, tipo_moneda, serie_transaccion, estado_transaccion)
VALUES
(1, 1, '2024-03-01', 'Cuenta 123', 'mensual', 1, 500.00, 500.00, 0.00, 1, 'USD', 'T001', '0'), -- pagado 
(2, 2, '2024-03-05', 'Cuenta 456', 'mensual', 2, 300.00, 150.00, 150.00, 2, 'Quetzales', 'T001', '1'); -- pendiente

-- Insertar datos en Tbl_proveedores
INSERT INTO `Tbl_proveedores` (fecha_registro, nombre_proveedor, direccion, telefono, email, saldo_cuenta, estado_proveedor)
VALUES
('2024-01-15', 'Proveedor A', 'Calle 100', '12345678', 'proveedorA@example.com', 0, '1'),
('2024-01-20', 'Proveedor B', 'Calle 200', '09876541', 'proveedorB@example.com', 0, '0');

-- Insertar datos en Tbl_Deudas_Proveedores
INSERT INTO `Tbl_Deudas_Proveedores` (Fk_id_proveedor, Fk_id_pago, monto_deuda, fecha_inicio_deuda, 
fecha_vencimiento_deuda, descripcion_deuda, estado_deuda)
VALUES
(1, 1, 1000.00, '2024-01-15', '2024-12-31', 'Deuda por compra de materiales', 0),  -- Inhabilitado 
(2, 2, 500.00, '2024-01-20', '2024-06-30', 'Deuda por servicios', 1);  -- Habilitado 

-- Insertar datos en Tbl_Transaccion_proveedor
INSERT INTO `Tbl_Transaccion_proveedor` (Fk_id_proveedor, Fk_id_pais, fecha_transaccion, cuenta_tansaccion, cuotas_transaccion, 
Fk_id_deuda, monto_deuda, monto_transaccion, saldo_pendiente, Fk_id_pago, tipo_moneda, serie_transaccion, estado_transaccion)
VALUES
(1, 1, '2024-02-01', 'Cuenta 100', 'menusal', 1, 1000.00, 1000.00, 0.00, 1, 'USD', 'P001', 0),  
(2, 2, '2024-02-05', 'Cuenta 200', 'mensual', 2, 500.00, 250.00, 250.00, 2, 'Quetzales', 'P002', 1); 