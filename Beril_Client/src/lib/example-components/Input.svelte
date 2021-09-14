<script lang="ts">
	import { tick } from 'svelte';
	let value = '';
	export let name = 'George';
	export let age = 23;

	async function onInput(event) {
		const input = this;
		let startSelection = input.selectionStart;
		let endSelection = input.selectionEnd;
		value = input.value.toUpperCase();
		await tick();
		input.selectionStart = startSelection;
		input.selectionEnd = endSelection;
	}
</script>

<h1>
	Hello {name}, your are {age}
</h1>

<input on:input={onInput} {value} />
