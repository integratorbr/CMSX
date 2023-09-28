$(document).ready(function() {
	$.Juitter.start({
		searchType:"fromUser", // Obrigat�rio. Voc� pode escolher entre "searchWord" (procurar palavra), "fromUser" (de um usu�rio), "toUser" (para um usu�rio)
		searchObject:"HotelHeritage", // Obrigat�rio. Voc� pode inserir uma palavra ou o nome do usu�rio. Para buscas m�ltiplas, separe as palavras por v�rgula. Para buscar por hashtagh, utilize o %23 antes da palavra.

		// Configura��es.
		lang:"", // Deixe vazio para n�o fazer nenhuma restri��o por idiomas. Utilize "pt" para portugu�s.
		live:"live-60", // O n�mero depois de "live-" indica o tempo em secundos entre cada atualiza��o. N�o exagere. ;-)
		placeHolder:"juitterContainer", // ID da div que ir� receber o conte�do.
		loadMSG: "Carregando...", // Mensagem exibida enquanto os tweets est�o sendo carregados. Para utilizar uma imagem, preencha o campo com "image/gif" e informe abaixo a URL. 
		imgName: "loader.gif", // URL da imagem enquanto os tweets est�o sendo carregados. Para funcionar voc� deve preencher o campo loadMSG com "image/gif".
		total: 3, // N�mero de tweets que ser�o exibidos. M�ximo 100.
		readMore: "Veja no Twitter", // Mensagem exibida ao final do tweet.
		nameUser:"image", // Preencha "image" para exibir o avatar dos usu�rios ou "text" para exibir apenas o nome dos usu�rios.
		openExternalLinks:"newWindow", // Defina como ser�o abertos os links de sites externos com "newWindow" (nova janela) ou "sameWindow" (mesma janela).
		filter:"dwarfurl.com,a0c2c,sexo"  // Os tweets que contenham qualquer uma dessas palavras n�o ser�o exibidos. 
	});       
        
});
