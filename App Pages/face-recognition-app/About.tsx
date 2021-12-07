import react from 'react'

function Untitled(props) {
    return (
      <Container>
        <Rect>
          <AboutUs>About Us</AboutUs>
        </Rect>
      </Container>
    );
  }
  
  const Container = `
    display: flex;
    background-color: rgba(114,189,235,1);
    flex-direction: column;
    height: 100vh;
    width: 100vw;
  `;
  
  const Rect = `
    width: 330px;
    height: 558px;
    background-color: rgba(248,249,251,1);
    border-radius: 30px;
    flex-direction: column;
    display: flex;
    margin-top: 39px;
    align-self: center;
  `;
  
  const AboutUs = `
    font-family: Roboto;
    font-style: normal;
    font-weight: 400;
    color: #121212;
    font-size: 40px;
    margin-top: 12px;
    margin-left: 84px;
  `;
  
  export default Untitled;

<div>
<h2>About Us</h2>

<p>About us text goes here</p>

</div>