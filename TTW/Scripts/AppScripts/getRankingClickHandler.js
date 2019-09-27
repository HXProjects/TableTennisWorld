const rankingSectionTitle = "[data-component='players-title']";
const rankingSectionTitleElement = document.querySelector(rankingSectionTitle);
const playersSectionContainer = "[data-component='player-section-container']";
const rankingSectElement = document.querySelector(playersSectionContainer);

let isPlayerSectionOpen = false;

$(function () {

    $(rankingSectionTitle).click(function () {
        console.log('click');
        if (!isPlayerSectionOpen) {
            $("#loading").show();
            $.getJSON("/Ranking/GetJsonRanking", null, getRanking);
        }
        else {
            removeRankingSectionContent();
        }
    });
});

function getRanking(ranking) {
    $("#loading").hide();
    const RankingContainer = document.createElement('div');
    RankingContainer.classList.add('players-section-box', 'background');    
    const Firstrow = document.createElement('div');
    Firstrow.classList.add('row-ranking');
    columnPlayer = document.createElement("div");
    columnPlayer.innerText = 'Player';
    columnPlayer.classList.add('column-ranking');
    const columnPosition = document.createElement("div");
    columnPosition.innerText = 'Position';
    columnPosition.classList.add('column-ranking');
    const columnCountry = document.createElement("div");
    columnCountry.innerText = 'Country';
    columnCountry.classList.add('column-ranking');

    
    Firstrow.appendChild(columnPosition);
    Firstrow.appendChild(columnPlayer);
    Firstrow.appendChild(columnCountry);
    console.log(rankingSectElement);
    RankingContainer.appendChild(Firstrow);

    $.each(ranking, function () {
        
        const row = document.createElement('div');
        row.classList.add('row-ranking');
        const player = document.createElement('div');
        player.innerText = this.Player;
        player.classList.add('column-ranking');
        const position = document.createElement('div');
        position.innerText = this.Position;
        player.classList.add('column-ranking');
        const country = document.createElement('div');
        country.innerText = this.Country;
        country.classList.add('column-ranking');
        console.log(this.Player == 1);
        if (this.Position === 1) {
            position.classList.add('first-player');
            country.classList.add('first-player');
            player.classList.add('first-player');

        }

        row.appendChild(position);
        row.appendChild(player);
        row.appendChild(country);
        RankingContainer.appendChild(row);
        
    });
    rankingSectElement.appendChild(RankingContainer);
    isPlayerSectionOpen = !isPlayerSectionOpen;
}
function removeRankingSectionContent() {
    while (rankingSectElement.firstChild) {
        rankingSectElement.removeChild(rankingSectElement.firstChild);
    }
    
    isPlayerSectionOpen = !isPlayerSectionOpen;
}