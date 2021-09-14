<script>
    import {Count} from "../stores/api-stores/TestStore";
    import {HomeStore} from "../stores/api-stores/HomeStore";
    
    const increment = () => {
       Count.update(x => x + 1) 
    };
</script>

<div>
<button on:click={increment}> 
+
</button>
   <h1>{$Count}</h1>
  <h1>
      {$HomeStore}</h1>

</div>
