const eventsSectionTitle = "[data-component='events-title']";
const eventsSectionTitleElement = document.querySelector(eventsSectionTitle);
const eventsSectionContainer = "[data-component='events-section-container']";
const eventSectElement = document.querySelector(eventsSectionContainer);

let isEventsSectionOpen = false;

$(function () {

    $(eventsSectionTitle).click(function () {
        console.log('click');
        if (!isEventsSectionOpen) {
            console.log('inrequest');
            $.getJSON("/Events/GetJsonAllEvents", null, getEvents);
        }
        else {
            removeEventsSectionContent();
        }
    });
});

function getEvents(events) {
    console.log('drawing');
    console.log(events);

        const futureCont = document.createElement('div');
        futureCont.classList.add('events-section-future');
        const titleFutureCont = document.createElement('h3');
        titleFutureCont.innerText = 'Coming soon';
        const activeCont = document.createElement('div');
        activeCont.classList.add('events-section-activ');
        const titleActiveCont = document.createElement('h3');
        titleActiveCont.innerText = 'In progress';
        const finishedCont = document.createElement('div');
        finishedCont.classList.add('events-section-finished');
        const titleFinishedCont = document.createElement('h3');
        titleFinishedCont.innerText = 'Finished';
        const ulFuture = document.createElement('ul');
        const ulActive = document.createElement('ul');
        const ulFinished = document.createElement('ul');

        futureCont.appendChild(titleFutureCont);
        activeCont.appendChild(titleActiveCont);
        finishedCont.appendChild(titleFinishedCont);

        
    $.each(events, function () {           
        
        const il = document.createElement('il');
        const linkTag = document.createElement('a');
        linkTag.innerText = this.Name + ':' + ' ' + this.Dates;
        il.appendChild(linkTag);
        if (this.Type === 'Active') {
            ulActive.appendChild(il)
        }
        if (this.Type === 'Future') {
            ulFuture.appendChild(il)
        }
        if (this.Type === 'Finished') {
            ulFinished.appendChild(il)
        }
        
    });
    futureCont.appendChild(ulFuture);
    finishedCont.appendChild(ulFinished);
    activeCont.appendChild(ulActive);
    eventSectElement.appendChild(futureCont);
    eventSectElement.appendChild(activeCont);
    eventSectElement.appendChild(finishedCont);


    eventsSectionTitleElement.classList.add('active-section-title');
    isEventsSectionOpen = !isEventsSectionOpen;
}
function removeEventsSectionContent() {
    while (eventSectElement.firstChild) {
        eventSectElement.removeChild(eventSectElement.firstChild);
    }
    eventsSectionTitleElement.classList.remove('active-section-title');
    isEventsSectionOpen = !isEventsSectionOpen;
}