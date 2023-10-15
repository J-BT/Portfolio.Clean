
export function clearTechnologiesContainer() {

    let technologiesContainer = document.getElementById("tech");
    let techImg = technologiesContainer.getElementsByTagName('img');

    while (techImg.length > 0) {
        technologiesContainer.removeChild(techImg[0]);
    }
}