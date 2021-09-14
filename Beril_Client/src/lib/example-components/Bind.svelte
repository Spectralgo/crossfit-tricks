<script>
let foo = '';

function onInput(e){
  foo = this.value
}
</script>

    <input type="text" on:input={onInput} >
<p>{foo}</p>
<button on:click={() => { foo += " ez"}}>
 click me 
</button>
<p class="absolute">yoo absoooute vodka</p>
<style>
	/* your styles go here */ 
  .absolute{
    position: relative;
    top: 60px ;


  }
</style>
