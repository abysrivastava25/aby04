import React, { Component } from 'react';
import ReactDOM from "react-dom";
import Item from "./Item/Item";
import './App.css';

class App extends Component {


  onSubmitClick=(event)=>{

    this.count++;
    let string=document.getElementById("data").value;
    let [name,quantity]=string.split("-");
    if(string.split("-").length!=2){
      alert("only name-quantity is allowed nothing else")
    }
    else{
      document.getElementById("this").insertAdjacentHTML("afterend",`<div id="item_${this.count}"></div>`)
      ReactDOM.render(<Item countNo={this.count} name={name} quantity={quantity}/>,document.getElementById(`item_${this.count}`))

    }

  }

  onEnter = (event)=>{
    if(event.key=="Enter"){
    this.onSubmitClick();
  }

  }

  render() {
    const style={
      backgroundColor: 'green',
      color:'white',
      font:'inherit',
      border:'1px solid blue',
      padding:'1px',
      cursor:'pointer'
    };


    return (
      <div className="App" id="appid">
        <input onKeyDown={this.onEnter} id="data" type="text" placeholder="name-quantity"/>
        <button
        style={style}
        className="btn btn-primary" onClick={this.onSubmitClick} type="button" >Submit</button>
        <div id="this">

        </div>
      </div>
    );

  }

}

export default App;
