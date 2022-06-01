/*CATEGORIA*/
insert into CategoriaSet(nome, ativo) values ('Prato Principal', 1);
insert into CategoriaSet(nome, ativo) values ('Prato Secundario', 0);
insert into CategoriaSet(nome, ativo) values ('Soupa', 1);
insert into CategoriaSet(nome, ativo) values ('Sobremesa', 1);
	select * from CategoriaSet;

/*MORADA*/
insert into MoradaSet(Rua, Cidade, CodPostal, Pais) values ('Alameda João Pedro Santos, 9722', 'Passagem Franca', '9535-836', 'Fiji');
insert into MoradaSet(Rua, Cidade, CodPostal, Pais) values ('Avenida Pedro Henrique Santos, 13', 'Ministro Andreazza', '2484-829', 'Vaticano');
insert into MoradaSet(Rua, Cidade, CodPostal, Pais) values ('Alameda Karla Costa, 623', 'Duque Bacelar', '0033-116', 'Território da Palestina');
insert into MoradaSet(Rua, Cidade, CodPostal, Pais) values ('Marginal Ana Laura Pereira, 3', 'Ponte Alta', '0085-426', 'Guiana');
insert into MoradaSet(Rua, Cidade, CodPostal, Pais) values ('Rodovia Clara Martins, 32', 'Gouvelândia', '6293-312', 'Belgrado');
insert into MoradaSet(Rua, Cidade, CodPostal, Pais) values ('Rua Márcia Saraiva, 983', 'Pedra Preta', '6507-564', 'Guiné Equatorial');
	select * from MoradaSet;

/*RESTAURANTE*/
	select * from RestauranteSet;

/*PESSOA*/
	select * from PessoaSet;

/*CLIENTE*/
	select * from PessoaSet_Cliente;

/*TRABALHADOR*/
	select * from PessoaSet_Trabalhador;

/*ITEM MENU*/
	select * from ItemMenuSet;

/*MENU RESTAURANTE*/
	select * from ItemMenuRestaurante;
	
/*ESTADO PEDIDO*/
	select * from EstadoSet;

/*ITEM PEDIDO*/
	select * from ItemMenuPedido;
	
/*METODO PAGAMENTO*/	
	select * from MetodoPagamentoSet;
	
/*PAGAMENTO*/	
	select * from PagamentoSet;
	
/*PEDIDO*/	
	select * from PedidoSet;