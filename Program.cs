using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia celular1 = new Nokia(numero:"7999999-9999", modelo:"A10", imei:"1234567890", memoria: 126);
celular1.InstalarAplicativo("Subway Surf");

Iphone celular2 = new Iphone(numero:"7999999-0000", modelo: "15 pro max", imei:"0987654321", memoria: 126);
celular2.InstalarAplicativo("DaVinci");