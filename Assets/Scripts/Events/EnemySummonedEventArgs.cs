namespace MonsterRPG
{
    public class EnemySummonedEventArgs
    {
        public readonly AbilitySystemComponent[] AbilitySystemComponents;

        public EnemySummonedEventArgs(AbilitySystemComponent[] abilitySystemComponents)
        {
            AbilitySystemComponents = abilitySystemComponents;
        }
    }
}
