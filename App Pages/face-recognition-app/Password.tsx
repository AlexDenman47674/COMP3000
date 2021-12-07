import react from 'react'

function Untitled(props) {
    return (
      <Container>
        <Rect></Rect>
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
    margin-top: 39px;
    align-self: center;
  `;
  
  export default Untitled;


<div>

<label>
        Previous Password
        <input type="text" name="PreviousPassword" />
    </label>
    <label>
        New Password
        <input type="text" name="NewPassword" />
    </label>
    <label>
        Re-enter Password
        <input type="text" name="RepeatPassword" />
    </label>
    /** Conformation checkbox */

    <button><h2>Update Password</h2></button>
</div>