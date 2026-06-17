# Micro Validation Report: stage11c_handoff_package

- stage: planning_stage_11c
- agent_id: critic
- session_id: notion-NeonDrift_MVP-0-12-20260617135727-stage11c_handoff_package
- output_folder: /home/node/.openclaw/workspace/382b9e33-8429-81e5-b017-e72d6bcabc4d/NeonDrift_MVP__test__notion-NeonDrift_MVP-0-12-20260617135727/project/

## Checks
- FAIL file.exists.handoffs/planning/11_critic_to_judge.md: missing
- FAIL process.trace_loaded: /home/node/.openclaw/agents/critic/sessions/notion-NeonDrift_MVP-0-12-20260617135727-stage11c_handoff_package.trajectory.jsonl
- PASS process.allowed_tools_only
- PASS process.no_tool_errors
- PASS process.final_text_no_blocked_or_no_reply
- FAIL process.final_text_success_marker: '' in /home/node/.openclaw/agents/critic/sessions/notion-NeonDrift_MVP-0-12-20260617135727-stage11c_handoff_package.jsonl
- FAIL process.write_read_pair.handoffs/planning/11_critic_to_judge.md

## Result
- status: failed

## Failures
- missing file: handoffs/planning/11_critic_to_judge.md
- missing trajectory toolMetas: /home/node/.openclaw/agents/critic/sessions/notion-NeonDrift_MVP-0-12-20260617135727-stage11c_handoff_package.trajectory.jsonl
- final assistant success marker must be exactly VERIFIED_WRITE_READ_COMPLETE
- missing write/read pair: handoffs/planning/11_critic_to_judge.md
