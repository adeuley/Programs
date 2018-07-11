var player1Name;
var player2Name;
var player1ShipHits=[0,0,0];
var player2ShipHits=[0,0,0];
var currentPlayer = 1;
var currentTurnActive = false;

function StartGame(){
	var startButton = document.getElementById("Start Button");
	startButton.parentNode.removeChild(startButton);
	
	var scoreButton = document.getElementById("Score Button");
	scoreButton.parentNode.removeChild(scoreButton);
	
	var scoreDiv = document.getElementById("Scores");
	while(scoreDiv.firstChild){
		scoreDiv.removeChild(scoreDiv.firstChild);
	}
	
	player1Name = prompt("Player 1 Please enter your name");
	var player1BoardPlacements = PromptForShipPlacement(player1Name);
	
	player2Name = prompt("Player 2 Please enter your name");
	var player2BoardPlacements = PromptForShipPlacement(player2Name);
	
	var startBoard = document.getElementById("PS0Table");
	startBoard.parentNode.removeChild(startBoard);
	
	CreateBoard("PlayersShots",true,1);
	CreateBoard("PlayersShots",true,2);
	CreateBoard("PlayersBoard",false,1);
	CreateBoard("PlayersBoard",false,2);
	
	PlaceShips(player1BoardPlacements,1);
	PlaceShips(player2BoardPlacements,2);
	
	ShowStartTurnButton(player1Name);
}
function PlaceShips(str,player){
	
	var query = /(([ABS]:[A-J](10|[1-9])-[A-J](10|[1-9])))|(([ABS]\([A-J](10|[1-9])-[A-J](10|[1-9])\)))/ig;
	var placements = str.match(query);
	
	for(p = 0; p<3; p++){
		var shipPlacement = placements[p];
		var shipType = shipPlacement.substring(0,1);
		
		//Get start and finish positions
		var startPosition;
		var endPosition;
		if(shipPlacement.includes(':')){
			var startPosition = shipPlacement.substring(shipPlacement.indexOf(":")+1,shipPlacement.indexOf("-"));
			var endPosition = shipPlacement.substring(shipPlacement.indexOf("-")+1);
		}
		else{
			var startPosition = shipPlacement.substring(shipPlacement.indexOf("(")+1,shipPlacement.indexOf("-"));
			var endPosition = shipPlacement.substring(shipPlacement.indexOf("-")+1,shipPlacement.indexOf(")"));
		}
				
		if(startPosition.charAt(0)==endPosition.charAt(0)){
			if(startPosition.substring(1) > endPosition.substring(1)){
				for(i = endPosition.substring(1);i <= startPosition.substring(1);i++){
					var cell = document.getElementById("PB"+player+i+ConvertColumnLetterToNumber(startPosition.charAt(0)));
					cell.innerHTML = shipType;
				}
			}
			else{
				for(i = startPosition.substring(1);i <= endPosition.substring(1);i++){
					var cell = document.getElementById("PB"+player+i+ConvertColumnLetterToNumber(startPosition.charAt(0)));
					cell.innerHTML = shipType;
				}
			}
		}
		else if(startPosition.substring(1) == endPosition.substring(1)){
			if(ConvertColumnLetterToNumber(startPosition.charAt(0)) > ConvertColumnLetterToNumber(endPosition.charAt(0))){
				for(i = ConvertColumnLetterToNumber(endPosition.charAt(0)); i <= ConvertColumnLetterToNumber(startPosition.charAt(0)); i++){
					var cell = document.getElementById("PB"+player+startPosition.substring(1)+i);
					cell.innerHTML = shipType;
				}
			}
			else{
				for(i = ConvertColumnLetterToNumber(startPosition.charAt(0)); i <= ConvertColumnLetterToNumber(endPosition.charAt(0)); i++){
					var cell = document.getElementById("PB"+player+startPosition.substring(1)+i);
					cell.innerHTML = shipType;
				}
			}
		}
		else{
			return false;
		}		
	}
}
function PromptForShipPlacement(name){
	var playerShipPlacement;
	do{
		playerShipPlacement = prompt(name + " where would you like to place your ships?\n(Examples: A:A1-A5;B:B6-E6; S:H3-J3 or A(A1-A5); B(B6-E6); S(H3-J3))");
	}while(!CheckShipPlacementString(playerShipPlacement))
		
	return playerShipPlacement;
}
function CheckShipPlacementString(str){
	//Split string and check that there are three strings
	var query = /(([ABS]:[A-J](10|[1-9])-[A-J](10|[1-9])))|(([ABS]\([A-J](10|[1-9])-[A-J](10|[1-9])\)))/ig;
	var placements = str.match(query);
	var placementCells = [];
	
	if(!Array.isArray(placements)){
		return false;
	}
	
	if(placements.length != 3){
		return false;
	}		
		
	//Verify that each ship type is the correct length and horizontal or vertical and doesn't overlap
	for(i = 0; i<placements.length; i++){
		var shipPlacement = placements[i];
		var shipType = shipPlacement.substr(0,1);
		
		//Get start and finish positions
		var startPosition;
		var endPosition;
		if(shipPlacement.includes(':')){
			var startPosition = shipPlacement.substring(shipPlacement.indexOf(":")+1,shipPlacement.indexOf("-"));
			var endPosition = shipPlacement.substring(shipPlacement.indexOf("-")+1);
		}
		else{
			var startPosition = shipPlacement.substring(shipPlacement.indexOf("(")+1,shipPlacement.indexOf("-"));
			var endPosition = shipPlacement.substring(shipPlacement.indexOf("-")+1,shipPlacement.indexOf(")"));
		}
		
		//Check Horizontal or Vertical & proper length
		if(startPosition.charAt(0)==endPosition.charAt(0)){
			if(shipType == 'A'){
				var shipLength = Math.abs(startPosition.substring(1) - endPosition.substring(1))+1;
				if(shipLength != 5){
					return false;
				}
				
			}
			else if(shipType == 'B'){
				var shipLength = Math.abs(startPosition.substring(1) - endPosition.substring(1))+1;
				if(shipLength != 4){
					return false;
				}
			}
			else if(shipType == 'S'){
				var shipLength = Math.abs(startPosition.substring(1) - endPosition.substring(1))+1;
				if(shipLength != 3){
					return false;
				}
			}
			
						
			if(startPosition.substring(1) < endPosition.substring(1)){
				var columnId = ConvertColumnLetterToNumber(startPosition.charAt(0));
				for(var i = startPosition.substring(1); i <= endPosition.substring(1); i++){
					var cellId = columnId+i;
					if(placementCells.length > 0){
						for(var j = 0; j<placementCells.length; j++){
							if(cellId == placementCells[j]){
								return false;
							}
						}
					}					
					placementCells.push(cellId);
				}
			}
			else{
				var columnId = ConvertColumnLetterToNumber(startPosition.charAt(0));
				for(var i = endPosition.substring(1); i <= startPosition.substring(1); i++){
					var cellId = columnId+i;
					if(placementCells.length > 0){
						for(var j = 0; j<placementCells.length; j++){
							if(cellId == placementCells[j]){
								return false;
							}
						}
					}					
					placementCells.push(cellId);
				}
			}
		}
		else if(startPosition.substring(1) == endPosition.substring(1)){
			if(shipType == 'A'){
				var shipLength = Math.abs(ConvertColumnLetterToNumber(startPosition.charAt(0)) - ConvertColumnLetterToNumber(endPosition.charAt(0)))+1;
				if(shipLength != 5){
					return false;
				}
			}
			else if(shipType == 'B'){
				var shipLength = Math.abs(ConvertColumnLetterToNumber(startPosition.charAt(0)) - ConvertColumnLetterToNumber(endPosition.charAt(0)))+1;
				if(shipLength != 4){
					return false;
				}
			}
			else if(shipType == 'S'){
				var shipLength = Math.abs(ConvertColumnLetterToNumber(startPosition.charAt(0)) - ConvertColumnLetterToNumber(endPosition.charAt(0)))+1;
				if(shipLength != 3){
					return false;
				}
			}
			
			if(ConvertColumnLetterToNumber(startPosition.charAt(0)) < ConvertColumnLetterToNumber(endPosition.charAt(0))){
				var columnId = ['-','A','B','C','D','E','F','G','H','I','J'];
				for(var i = ConvertColumnLetterToNumber(startPosition.charAt(0)); i <= ConvertColumnLetterToNumber(endPosition.charAt(0)); i++){
					var cellId = columnId[i]+startPosition.substring(1);
					if(placementCells.length > 0){
						for(var j = 0; j<placementCells.length; j++)
						{
							if(cellId == placementCells[j]){
								return false;
							}
						}
					}					
					placementCells.push(cellId);
				}
			}
			else{
				var columnId = ['-','A','B','C','D','E','F','G','H','I','J'];
				for(var i = ConvertColumnLetterToNumber(endPosition.charAt(0)); i <= ConvertColumnLetterToNumber(startPosition.charAt(0)); i++){
					var cellId = columnId[i]+i;
					if(placementCells.length > 0){
						for(var j = 0; j<placementCells.length; j++)
						{
							if(cellId == placementCells[j]){
								return false;
							}
						}
					}					
					placementCells.push(cellId);
				}
			}
		}
		else{
			return false;
		}		
	}
	
	
	
	return true;	
}
function ShowStartTurnButton(name){
	
	HideAllBoards();	
	
	var buttonDiv = document.getElementById("Buttons");
	var startTurnButton = document.createElement("button");
	startTurnButton.setAttribute("id","StartTurnButton");
	startTurnButton.innerHTML = name + " click to start turn";
	startTurnButton.addEventListener("click",function(){PlayerTurn(name);});
	buttonDiv.appendChild(startTurnButton);
}
function PlayerTurn(){
	
	currentTurnActive = true;
	
	var startButton = document.getElementById("StartTurnButton");
	startButton.parentNode.removeChild(startButton);
	
	var playerShotBoard = document.getElementById("PS"+currentPlayer+"Table");
	playerShotBoard.removeAttribute('class');
	
	var playerBoard = document.getElementById("PB"+currentPlayer+"Table");
	playerBoard.removeAttribute('class');
}
function HideAllBoards(){
	var player1ShotBoard = document.getElementById("PS1Table");
	player1ShotBoard.setAttribute('class','hidden');
	var player1ShipBoard = document.getElementById("PB1Table");
	player1ShipBoard.setAttribute('class','hidden');
	var player2ShotBoard = document.getElementById("PS2Table");
	player2ShotBoard.setAttribute('class','hidden');
	var player2ShipBoard = document.getElementById("PB2Table");
	player2ShipBoard.setAttribute('class','hidden');
}
function CreateBoard(div,SetOnClick,player){
	var letters = ['-','A','B','C','D','E','F','G','H','I','J'];
	
	var boardDiv = document.getElementById(div);
	var playerShotBoardNode = document.createElement('table');
	
	var tableId;
	if(div == 'PlayersShots'){
		tableId = "PS" + player + "Table";
	}
	else{
		tableId = "PB" + player + "Table";
	}
	
	playerShotBoardNode.setAttribute('id',tableId);
	boardDiv.appendChild(playerShotBoardNode);
	
	for(var i = 0;i <11;i++){
		var row = document.createElement('tr');
		
		for(var j=0;j<11;j++){
			var cell = document.createElement('td');
			if(i==0)
			{
				if(j>0)
				{
					cell.innerHTML = letters[j];
				}
			}
			else if(j==0){
				cell.innerHTML = i;
			}
			else
			{			
				if(SetOnClick==true)
				{	
					cell.addEventListener('click',function(){CellClick(this.id,this.className);});
				}
			}
			var cellId;
			if(div == 'PlayersShots')
			{
				cellId = "PS" + player + i+j;
			}
			else
			{
				cellId = "PB" + player + i + j;
			}
			cell.setAttribute('id',cellId);
			row.appendChild(cell);
		}
		document.getElementById(tableId).appendChild(row);
	}
	
}
function CellClick(cellId,cellClass){
	if(cellClass != "miss" && cellClass != "hit"){
		if(currentTurnActive)
		{
			var player = currentPlayer;
			var opponent;
			if(currentPlayer == 1){
				opponent = 2;
			}
			else{
				opponent = 1;
			}
			
			var opponentCellId = cellId.replace(player,opponent);
			opponentCellId = opponentCellId.replace("PS","PB")

			var opponentCell = document.getElementById(opponentCellId);
			var shotResult;
			if(opponentCell.innerHTML=='A'||opponentCell.innerHTML=='B'||opponentCell.innerHTML=='S'){
				shotResult = 'Hit';
			}
			else{
				shotResult = 'Miss';
			}
			
			if(shotResult == 'Miss'){
				opponentCell.setAttribute('class','miss');
				var playerCell = document.getElementById(cellId);
				playerCell.setAttribute('class','miss');
				alert("Miss");
			}
			else{
				opponentCell.setAttribute('class','hit');
				var playerCell = document.getElementById(cellId);
				playerCell.setAttribute('class','hit');
				IncreaseScore(opponentCell.innerHTML);
				var shipSunk = CheckShipSunk(opponentCell.innerHTML);
				if(shipSunk == "None"){
					alert("Hit!");
				}
				else{
					alert("Hit! You sunk their "+ shipSunk + "!");
				}	
				CheckWin();
			}
			
			var buttonDiv = document.getElementById("Buttons");
			var endTurnButton = document.createElement("button");
			endTurnButton.setAttribute("id","EndTurnButton");
			endTurnButton.innerHTML = name + " click to end turn";
			endTurnButton.addEventListener("click",function(){EndTurn();});
			buttonDiv.appendChild(endTurnButton);	
			
			currentTurnActive = false;
		}
	}
}
function CheckShipSunk(shipType){
	if(currentPlayer === 1){
		if(shipType == 'A'){
			if(player2ShipHits[0] >= 5){
				return "Aircraft Carrier";
			}
			else{
				return "None";
			}
		}
		else if (shipType == 'B'){
			if(player2ShipHits[1] >= 4){
				return "Battleship";
			}	
			else{
				return "None";
			}
		}
		else if (shipType == 'S'){
			if(player2ShipHits[2] >= 3){
				return "Submarine";
			}	
			else{
				return "None";
			}			
		}
		else{
			return "None";
		}
	}
	else{
		if(shipType == 'A'){
			if(player1ShipHits[0] >= 5){
				return "Aircraft Carrier";
			}
			else{
				return "None";
			}
		}
		else if (shipType == 'B'){
			if(player1ShipHits[1] >= 4){
				return "Battleship";
			}	
			else{
				return "None";
			}
		}
		else if (shipType == 'S'){
			if(player1ShipHits[2] >= 3){
				return "Submarine";
			}	
			else{
				return "None";
			}			
		}
		else{
			return "None";
		}
	}
}
function CheckWin(){
	if(currentPlayer === 1){
		if(player2ShipHits[0] >= 5 && player2ShipHits[1] >= 4 && player2ShipHits[2] >= 3){
			EndGame(player1Name,player1ShipHits);
		}		
	}
	else{
		if(player1ShipHits[0] >= 5 && player1ShipHits[1] >= 4 && player1ShipHits[2] >= 3){
			EndGame(player2Name,player2ShipHits);
		}
	}
}
function EndGame(name,shipHits){
	alert(name + " Wins!");
	//Calculate score
	var score = 24 - shipHits[0]*2 - shipHits[1]*2 - shipHits[2]*2;
	alert("Your score is "+score);
	//Add score to local storage
	StoreScore(name,score);
	//Start game over
	alert("Click OK to refresh window and start a new game");
	location.reload();
}
function EndTurn(){
	var endButton = document.getElementById("EndTurnButton");
	endButton.parentNode.removeChild(endButton);
	
	if(currentPlayer == 1){
		currentPlayer = 2;
		ShowStartTurnButton(player2Name);
	}
	else {
		currentPlayer = 1;
		ShowStartTurnButton(player1Name);
	}
}
function IncreaseScore(shipHit){
	if(shipHit == 'A'){
		if(currentPlayer == 1){
			player2ShipHits[0]++;
		}
		else{
			player1ShipHits[0]++;
		}
	}
	else if(shipHit == 'B'){
		if(currentPlayer == 1){
			player2ShipHits[1]++;
		}
		else{
			player1ShipHits[1]++;
		}		
	}
	else if(shipHit == 'S'){
		if(currentPlayer == 1){
			player2ShipHits[2]++;
		}
		else{
			player1ShipHits[2]++;
		}		
	}
}
function ConvertColumnLetterToNumber(input){
	if(input == 'A'){
		return 1;
	}
	else if(input == 'B'){
		return 2;
	}
	else if(input == 'C'){
		return 3;
	}
	else if(input == 'D'){
		return 4;
	}
	else if(input == 'E'){
		return 5;
	}
	else if(input == 'F'){
		return 6;
	}
	else if(input == 'G'){
		return 7;
	}
	else if(input == 'H'){
		return 8;
	}
	else if(input == 'I'){
		return 9;
	}
	else if(input == 'J'){
		return 10;
	}
	else{
		return 0;
	}
}
function ShowScore(){
	var scores = GetScores();
	var scoreDiv = document.getElementById("Scores");
	
	while(scoreDiv.firstChild){
		scoreDiv.removeChild(scoreDiv.firstChild);
	}
	
	var totalScores = 10;
	if(scores.length < 10){
		totalScores = scores.length;
	}
	
	for(var i = 0; i < totalScores; i++){
		var newScore = document.createElement("p");
		newScore.setAttribute("id","Scores" + i);
		var test = scores[i].split(';');
		newScore.innerHTML = test[0] + ": " + test[1];
		scoreDiv.appendChild(newScore);
	}
}
function StoreScore(name,score){
	var currentScores = GetScores();
	var deSerializedScores = [];
	for(var i = 0; i < currentScores.length;i++){
		var cScore = currentScores[i];
		var splitScore = cScore.split(';');
		var scoreObject = {playerName: splitScore[0],playerScore: splitScore[1]};
		deSerializedScores.push(scoreObject);
	}
	
	var newScoreObject = {playerName:name,playerScore:score};
	
	deSerializedScores.push(newScoreObject);
	deSerializedScores.sort(function(a,b){return b.playerScore - a.playerScore});
	SetScores(deSerializedScores);
}
function SetScores(scores){
	localStorage.clear();
	var totalScores = 10;
	if(scores.length < 10){
		totalScores = scores.length;
	}
	
	for(var i = 0; i < totalScores;i++){
		localStorage.setItem(i,scores[i].playerName+";"+scores[i].playerScore);
	}
}
function GetScores(){
	var scoreString = "";
	var scores = [];
	var i = 0;
	do{
		scoreString = localStorage.getItem(i);
		if(scoreString != null){
			scores.push(scoreString);
		}
		i++;
	}while(scoreString != null)
	return scores;
}
