const newsSectionTitle = "[data-component='news-title']";
const newsSectionTitleElement = document.querySelector(newsSectionTitle);
const newsSectionDataComp = "[data-component='news-section-container']";
const newsSectCont = document.querySelector(newsSectionDataComp);
let isNewsSectionOpen = false;

$(function () {    
    $('.carousel').carousel();
    $(newsSectionTitle).click(function () {
        if (!isNewsSectionOpen) {
            $("#loading").show();
            $.getJSON("/News/GetNews", null, getNews);
            
        }
        else{
            removeNewsSection();            
        }
    });
});

function getNews(news) {
    $("#loading").hide();
        $.each(news, function () {
            const divContBox = document.createElement('div');
            divContBox.classList.add('news-section_box');
            const newsImg = document.createElement('img');
            newsImg.classList.add('news-section_box-image');
            newsImg.src = this.ImageLink;
            const contentContainer = document.createElement('div');
            contentContainer.classList.add('news-section_box-content_container');
            const newsTitl = document.createElement('h3')
            newsTitl.classList.add('news-section_box-title');
            newsTitl.innerText = this.Title;
            const date = document.createElement('h6');
            date.innerText = this.Date;
            
            const contentTextCont = document.createElement('div');
            contentTextCont.classList.add('news-section_box-content');
            contentTextCont.innerText = this.Content;

            contentContainer.appendChild(newsTitl);
            contentContainer.appendChild(contentTextCont);
            contentContainer.appendChild(date);

            divContBox.appendChild(newsImg);
            divContBox.appendChild(contentContainer);
            newsSectCont.appendChild(divContBox);

        });
        newsSectionTitleElement.classList.add('active-section-title');
        isNewsSectionOpen = !isNewsSectionOpen;
    
}
function removeNewsSection() {    
    while (newsSectCont.firstChild) {
        newsSectCont.removeChild(newsSectCont.firstChild);
    }
    newsSectionTitleElement.classList.remove('active-section-title');
    isNewsSectionOpen = !isNewsSectionOpen;
}
