
<script>
	import { createEventDispatcher } from 'svelte';

	let dispatch = createEventDispatcher();
	function onClick1(event) {
		dispatch('componentButtonClick', 'Button 1 Clicked');
	}

	function onClick2(event) {
		dispatch('componentButtonClick', 'Button 2 Clicked');
	}
</script>

<div>
	<button on:click>Button 1</button>
	<!-- <button on:click={onClick1}>Button 1</button> -->
	<button on:click={onClick2}>Button 2</button>
</div>

<style>
	div {
		display: flex;
		justify-items: auto;
	}
</style>
