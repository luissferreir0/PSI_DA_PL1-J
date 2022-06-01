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
insert into RestauranteSet(Nome, Morada_Id) values ('Don Mino', 5);
insert into RestauranteSet(Nome, Morada_Id) values ('SubTrain', 3);
	select * from RestauranteSet;

/*PESSOA*/
insert into PessoaSet(Nome, Telemovel, IdMorada) values ('Derdriu', 967365705, 6); -- Cliente
insert into PessoaSet(Nome, Telemovel, IdMorada) values ('Urmazd', 934044713, 4);  -- Trabalhador
insert into PessoaSet(Nome, Telemovel, IdMorada) values ('Kawiil', 930744609, 5);  -- Trabalhador
insert into PessoaSet(Nome, Telemovel, IdMorada) values ('Mohana', 932712921, 2);  -- Cliente
insert into PessoaSet(Nome, Telemovel, IdMorada) values ('Phoibos', 968741992, 5); -- Trabalhador
	select * from PessoaSet;

/*CLIENTE*/
insert into PessoaSet_Cliente(TotalGasto, NumContribuinte, Id) values (501.25, 220479704, 1);
insert into PessoaSet_Cliente(TotalGasto, NumContribuinte, Id) values (243.26, 111809821, 5);
	select * from PessoaSet_Cliente;

/*TRABALHADOR*/
insert into PessoaSet_Trabalhador(Salario, Posicao, RestauranteId, Id) values (1500.6, 'Empregador de Mesa', 1, 2);
insert into PessoaSet_Trabalhador(Salario, Posicao, RestauranteId, Id) values (1790.3, 'Cozinheiro', 1, 3);
insert into PessoaSet_Trabalhador(Salario, Posicao, RestauranteId, Id) values (2500.5, 'Administrador', 2, 6);
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