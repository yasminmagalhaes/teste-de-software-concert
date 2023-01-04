# Automação de testes - Google

Testes automatizados usando Selenium WebDriver com o Dotnet na linguagem C#, testando a plataforma de pesquisa Google.
Para conhecer o resultado do código, fiz um vídeo demonstrando sua utilização: 

https://user-images.githubusercontent.com/72515480/210497631-c454f22d-30c0-4701-ac10-6fd3c4a70617.mp4

No vídeo, o tempo de pausa entre as ações foi prolongado apenas para melhor demonstração, os testes podem ser feitos sem a pausa. 
Link do vídeo: https://www.loom.com/share/2720357bbef0448ab160834e232ae618

<h2>Usabilidade Google:</h2>

Apesar de muito utilizado, no dia a dia não paramos para analisar como é o processo de uso do maior buscador da internet, o Google.
Pensando nisso, tirei alguns momentos para realizar testes manuais para observar e avaliar melhor os detalhes de usabilidade, onde pude também dedicar esse tempo para decidir o percurso que percorreria nos testes autotomizados.

Antes de partir para o código, alguns detalhes sobre a usabilidade do Google me chamaram atenção e citarei aqui:
- A página inicial é objetiva, dando apenas as opções principais de uso;
- Entretanto, após realizar uma pesquisa, a mesma pesquisa pode gerar resultados diferentes, tanto nas informações expostas, como nos posicionamentos dos resultados;
- Esse ponto citado acima pode se tratar de um teste A/B com os usuários, porém torna confuso seu trajeto no momento em que o usuário poderá realizar uma pesquisa e encontrar algo do seu interesse e ao realizar novamente a mesma pesquisa em instantes, poderá perder de vista o que havia encontrado;
- Um dos pontos mais intrigante durante essa análise foi o posicionamento dos filtros principais localizados na barra horizontal, logo abaixo do campo de busca, onde posso citar dois detalhes que me chamaram atenção:
- -  O posicionamento desses filtros podem variar conforme a pesquisa como, por exemplo, se for pesquisado destinos de viagens, o filtro "Voos" e "Maps" podem aparecer em destaque dentre os elementos de filtros, mostrando que a filtragem é inteligente ao absorver a informação e personalizar a experiência do usuário através desses filtros dinâmicos;
- - O segundo detalhe que me chamou a atenção foi o fato de ao selecionar outro filtro que não seja o filtro "Todas", o filtro selecionado não permanece no mesmo lugar, ou seja, se o filtro "Imagens" está na segunda colocação sendo clicado, ele se move para terceira ou quarta colocação. Mesmo tendo um provável proposito, no final, essa ação pode deixar o usuário perdido no momento de voltar a buscar outros filtros.
- Além disso, a plataforma possui ferramentas que auxiliam na busca, pouco conhecidas e pouco utilizadas, mas com uma grande eficácia.

<h2>Automação do teste</h2>

Para realizar a automação do teste na plataforma de pesquisas Google, segui como princípio o percurso cognitivo para avaliar a interface, utilizando esse método para absorver uma ideia de caminho a ser percorrido durante os testes.
Apesar de não objetificar um resultado específico final como seria no percurso cognitivo, realizei caminhos que identifiquei que o usuário faria enquanto tentaria alcançar algum objetivo.

O caminho que utilizei teve como objetivo a busca sobre "Bolsas", onde o usuário inicia sua busca digitando a mesma como palavra-chave, logo após segue utilizando sugestões da própria plataforma e explora as filtragens para afunilar sua busca.

<h3>Técnico</h3>
Para esses testes, foi utilizado Selenium WebDriver com o Dotnet na linguagem C#.
<br>Em resumo, foram testadas os seguintes itens: title e mudança do title, campo de busca, campos de filtragens, campo de ferramentes e validação do usuário;

Abaixo, listo o passo a passo que é o teste realiza:
- Abre o navegador;
- Abre o site https://www.google.com.br;
- É verificado se o title está com o nome "Google";
- Após a página carregar por completo, clica no campo de busca;
- Digita o termo "Bolsa";
- Clica no botão de pesquisa que surge logo abaixo das sugestões;
- Por padrão, o Google utiliza o termo buscado no seu title junto com "- Pesquisa Google", então é verificado se o title está igual a "Bolsa - Pesquisa Google";
- Após o resultado da busca ser carregado, o botão "x" do campo de busca é clicado, limpando o campo;
- Com o campo limpo, é apresentado pelo Google diversas sugestões de buscas baseadas na pesquisa feita anteriormente, a primeira dessas sugestões recebe um clique;
- Novos resultados são carregados, nesse momento é iniciado a utilização dos filtros, clicando sobre o segundo filtro ao lado de "Todas";
- Após a nova página carregar, a posição de segundo filtro ao lado de "Todas" recebe outro filtro, então é clicado sobre ele;
- Retornamos ao filtro inicial "Todas" clicando sobre ele;
- É utilizado agora o botão ferramenta, clicando sobre ele;
- Após o clique no botão, novas filtragens são apresentadas, é clicado sobre a opção de data e alterado para "Nas últimas 24h";
- Por fim, é clicado na área de login, onde o processo de inserção de e-mail e clique para avançar é realizado, finalizando assim o teste dentro das limitações de acesso ao login;

Teste automatizado feito por Yasmin Magalhães para avaliação Concert.
