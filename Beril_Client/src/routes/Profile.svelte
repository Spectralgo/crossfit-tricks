<script >
  import {afterUpdate, createEventDispatcher, tick} from "svelte";


	export let status;
	export let name;
	export let skillPoints = 0;
	$: skillPoints
	
	  
let dispatch = createEventDispatcher()

    $: dispatch("skillPointChange", skillPoints)

	const decrement = () => {
		skillPoints--;
	};

	const increment = () => {
		skillPoints++;
	};
</script>

<section>
<h2>Name</h2>
<h3>{name}</h3>

<h2>Status</h2>
<h3>{status}</h3>

<div>
	<div>
		<button on:click={decrement}> - </button>
		<p>{skillPoints}</p>
		<button on:click={increment}> + </button>
	</div>
</div>

</section>
<style>
	div > * {
		margin: 5px;
		display: flex;
	}

	h2 {
		margin-left: 1%;
	}

	h3 {
		color: purple;
		margin-left: 1%;
	}
section {
	border-style: solid;
	border-color: black;
	display: flex;
	justify-content: center;
	align-items: center;

}
</style>
